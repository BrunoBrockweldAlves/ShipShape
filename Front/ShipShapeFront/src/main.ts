import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';


platformBrowserDynamic().bootstrapModule(AppModule)
  .catch(err => console.error(err));
  
  // const menu = document.querySelector('.menu');
  // const NavMenu = document.querySelector('.nav-menu');
  
  // menu.addEventListener('click', () => {
  //     menu.classList.toggle('ativo');
  //     NavMenu.classList.toggle('ativo');
  // })
  