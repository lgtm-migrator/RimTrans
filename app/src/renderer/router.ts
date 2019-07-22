import Vue from 'vue';
import VueRouter from 'vue-router';

export function createRouter(): VueRouter {
  return new VueRouter({
    mode: 'hash',
    base: process.env.BASE_URL,
    routes: [
      {
        path: '/',
        name: 'welcome',
        component: async () =>
          import(/* webpackChunkName: "welcome" */ './views/welcome'),
      },
      {
        path: '/settings',
        component: async () =>
          import(/* webpackChunkName: "v-settings" */ './views/settings/settings'),
        children: [
          {
            path: '',
            name: 'settings',
            redirect: 'languages',
          },
          {
            path: 'languages',
            name: 'settings-languages',
            component: async () =>
              import(/* webpackChunkName: "v-settings" */ './views/settings/languages'),
          },
        ],
      },

      {
        path: '/translator',
        name: 'translator',
        component: async () =>
          import(/* webpackChunkName: "v-dev-tools" */ './views/dev-tools/place-holder'),
      },
      {
        path: '/modder',
        name: 'modder',
        component: async () =>
          import(/* webpackChunkName: "v-dev-tools" */ './views/dev-tools/place-holder'),
      },

      // dev-tools
      {
        path: '/dev-tools/icons',
        name: 'dev-tools-icons',
        component: async () =>
          import(/* webpackChunkName: "v-dev-tools" */ './views/dev-tools/icons'),
      },
    ],
  });
}
