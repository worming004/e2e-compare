/// <reference types="Cypress" />

describe("My First Test", () => {
  it("Visits the Kitchen Sink", () => {
    cy.visit("https://bar.craftlabit.be");
    cy.contains("SANS GLUTEN").click();

    const token = cy.get("div.rounded-full[style*='background-color: orange']")
    
    token
      .children() // no need to find child to get text ! see next contains
      .first()
      .contains("1");

    cy.contains("MAES").click();

    token
      // .children() // no need to find child to get text !
      // .first()
      .contains("2");
  });
});
