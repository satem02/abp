import { SatemTemplatePage } from './app.po';

describe('Satem App', function() {
  let page: SatemTemplatePage;

  beforeEach(() => {
    page = new SatemTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
