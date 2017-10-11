import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { NgModule, ApplicationRef } from '@angular/core';
import { AppComponent } from './app.component';
import { createInputTransfer, createNewHosts, removeNgStyles } from '@angularclass/hmr';
import { IctService } from './services/ict.service';
import { HomeComponent } from './components/home/home.component';
import { PresentationGridComponent } from './components/presentation-grid/presentation-grid.component';
import { GalleryComponent } from './components/gallery/gallery.component';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    PresentationGridComponent,
    GalleryComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot([{
      path: '',
      pathMatch: 'full',
      redirectTo: 'home'
    }, {
      path: 'home',
      component: HomeComponent
    }, {
      path: 'presentations',
      component: PresentationGridComponent,
    }, {
      path: 'gallery',
      redirectTo: 'gallery/1'
    },
    {
      path: 'gallery/:page',
      component: GalleryComponent
    }])
  ],
  providers: [IctService],
  bootstrap: [AppComponent]
})
export class AppModule {
  constructor(public appRef: ApplicationRef) { }
  hmrOnInit(store) {
    if (!store || !store.state) return;

    if ('restoreInputValues' in store) {
      store.restoreInputValues();
    }

    this.appRef.tick();
    delete store.state;
    delete store.restoreInputValues;
  }

  hmrOnDestroy(store) {
    let cmpLocation = this.appRef.components.map(cmp => cmp.location.nativeElement);
    store.disposeOldHosts = createNewHosts(cmpLocation);
    store.state = {};
    store.restoreInputValues = createInputTransfer();
    removeNgStyles();
  }
  hmrAfterDestroy(store) {
    store.disposeOldHosts();
    delete store.disposeOldHosts;
  }
}
