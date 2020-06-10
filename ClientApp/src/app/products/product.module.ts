import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router";
import { CommonModule } from "@angular/common";

import { ProductListComponent } from "./product-list.component";
import { ProductDetailComponent } from "./product-detail.component";

@NgModule({
  declarations: [ProductListComponent, ProductDetailComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([
      { path: "products", component: ProductListComponent },
      {
        path: "products/:id",
        component: ProductDetailComponent,
      },
    ]),
  ],
})
export class ProductModule {}
