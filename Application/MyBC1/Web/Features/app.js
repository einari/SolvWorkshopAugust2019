import { PLATFORM } from 'aurelia-pal';

export class app {
    constructor() {
    }

    configureRouter(config, router) {
        config.options.pushState = true;
        config.map([
            { route: '', name: 'Home', moduleId: PLATFORM.moduleName('Accounts/index') }
        ]);

        this.router = router;
    }
}
