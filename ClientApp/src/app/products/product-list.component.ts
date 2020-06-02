import { Component, Inject, OnInit } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { IProduct } from "./product";
import { ProductService } from "./product.service";

@Component({
  selector: "app-fetch-data",
  templateUrl: "./product-list.component.html",
  styleUrls: ["./product-list.component.css"],
})
export class ProductListComponent implements OnInit {
  public products: IProduct[];
  componentTitle = "Products List";
  errorMessage = "";

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.productService.getProducts().subscribe(
      (result) => {
        this.products = result;
      },
      (error) => {
        console.error(error);
        this.errorMessage =
          "Couldn't load products temporarily, please try again later.";
      }
    );
  }
}
