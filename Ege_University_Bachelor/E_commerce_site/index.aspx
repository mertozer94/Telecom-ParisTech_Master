﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="container">
                <div class="col-xs-12">
                    <!-- ========================================== SECTION – HERO ========================================= -->

                    <div id="hero">
                        <div id="owl-main" class="owl-carousel height-lg owl-inner-nav owl-ui-lg">

                            <div class="item" style="background-image: url(assets/images/sliders/slider02.jpg);">
                                <div class="container-fluid">
                                    <div class="caption vertical-center text-left right" style="padding-right:0;">
                                        <div class="big-text fadeInDown-1">
                                            Save up to a<span class="big"><span class="sign">$</span>400</span>
                                        </div>
                                        <div class="excerpt fadeInDown-2">
                                            on selected laptops<br>
                                            &amp; desktop pcs or<br>
                                            smartphones
                                        </div>
                                        <div class="small fadeInDown-2">
                                            terms and conditions apply
                                        </div>
                                        <div class="button-holder fadeInDown-3">
                                            <a href="single-product.aspx" class="big le-button ">shop now</a>
                                        </div>
                                    </div><!-- /.caption -->
                                </div><!-- /.container-fluid -->
                            </div><!-- /.item -->
                            <div class="item" style="background-image: url(assets/images/sliders/slider04.jpg);">
                                <div class="container-fluid">
                                    <div class="caption vertical-center text-left left" style="padding-left:7%;">
                                        <div class="big-text fadeInDown-1">
                                            Want a<span class="big"><span class="sign">$</span>200</span>Discount?
                                        </div>
                                        <div class="excerpt fadeInDown-2">
                                            on desktop pcs
                                        </div>
                                        <div class="small fadeInDown-2">
                                            terms and conditions apply
                                        </div>
                                        <div class="button-holder fadeInDown-3">
                                            <a href="single-product.aspx" class="big le-button ">shop now</a>
                                        </div>
                                    </div><!-- /.caption -->
                                </div><!-- /.container-fluid -->
                            </div><!-- /.item -->
                        </div><!-- /.owl-carousel -->
                    </div>

                    <!-- ========================================= SECTION – HERO : END ========================================= -->
                </div>
            </div>
            <section id="banner-holder" class="wow fadeInUp">
            <div class="container">
                <div class="col-xs-12 col-lg-6 no-margin banner">
                    <a href="category-grid-2">
                        <div class="banner-text theblue">
                            <h1>New Life</h1>
                            <span class="tagline">Introducing New Category</span>
                        </div>
                        <img class="banner-image" alt="" src="assets/images/blank.gif" data-echo="assets/images/banners/banner-narrow-01.jpg" />
                    </a>
                </div>
                <div class="col-xs-12 col-lg-6 no-margin text-right banner">
                    <a href="category-grid-2">
                        <div class="banner-text right">
                            <h1>Time &amp; Style</h1>
                            <span class="tagline">Checkout new arrivals</span>
                        </div>
                        <img class="banner-image" alt="" src="assets/images/blank.gif" data-echo="assets/images/banners/banner-narrow-02.jpg" />
                    </a>
                </div>
            </div><!-- /.container -->
        </section><!-- /#banner-holder -->
        <!-- ========================================= HOME BANNERS : END ========================================= -->
        <div id="products-tab" class="wow fadeInUp">
            <div class="container">
                <div class="tab-holder">
                    <!-- Nav tabs -->
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#featured" data-toggle="tab">featured</a></li>
                        <li><a href="#new-arrivals" data-toggle="tab">new arrivals</a></li>
                        <li><a href="#top-sales" data-toggle="tab">top sales</a></li>
                    </ul>
                    <!-- Tab panes -->
                    <div class="tab-content">
                        <div class="tab-pane active" id="featured">
                            <div class="product-grid-holder">
                                <div class="col-sm-4 col-md-3  no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="ribbon red"><span>sale</span></div>
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-01.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount green">-50% sale</div>
                                            <div class="title">
                                                <a href="single-product.aspx">VAIO Fit Laptop - Windows 8 SVF14322CXW</a>
                                            </div>
                                            <div class="brand">sony</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="ribbon blue"><span>new!</span></div>
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-02.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount clear"></div>
                                            <div class="title">
                                                <a href="single-product.aspx">White lumia 9001</a>
                                            </div>
                                            <div class="brand">nokia</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-03.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount clear"></div>
                                            <div class="title">
                                                <a href="single-product.aspx">POV Action Cam</a>
                                            </div>
                                            <div class="brand">sony</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="ribbon red"><span>sale</span></div>
                                        <div class="ribbon green"><span>bestseller</span></div>
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-04.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount clear"></div>
                                            <div class="title">
                                                <a href="single-product.aspx">
                                                    Netbook Acer TravelMate
                                                    B113-E-10072
                                                </a>
                                            </div>
                                            <div class="brand">acer</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="loadmore-holder text-center">
                                <a class="btn-loadmore" href="#">
                                    <i class="fa fa-plus"></i>
                                    load more products
                                </a>
                            </div>
                        </div>
                        <div class="tab-pane" id="new-arrivals">
                            <div class="product-grid-holder">

                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="ribbon blue"><span>new!</span></div>
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-02.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount clear"></div>
                                            <div class="title">
                                                <a href="single-product.aspx">White lumia 9001</a>
                                            </div>
                                            <div class="brand">nokia</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="ribbon red"><span>sale</span></div>
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-01.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount green">-50% sale</div>
                                            <div class="title">
                                                <a href="single-product.aspx">VAIO Fit Laptop - Windows 8 SVF14322CXW</a>
                                            </div>
                                            <div class="brand">sony</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="ribbon red"><span>sale</span></div>
                                        <div class="ribbon green"><span>bestseller</span></div>
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-04.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount clear"></div>
                                            <div class="title">
                                                <a href="single-product.aspx">
                                                    Netbook Acer TravelMate
                                                    B113-E-10072
                                                </a>
                                            </div>
                                            <div class="brand">acer</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-03.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount clear"></div>
                                            <div class="title">
                                                <a href="single-product.aspx">POV Action Cam</a>
                                            </div>
                                            <div class="brand">sony</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="loadmore-holder text-center">
                                <a class="btn-loadmore" href="#">
                                    <i class="fa fa-plus"></i>
                                    load more products
                                </a>
                            </div>
                        </div>
                        <div class="tab-pane" id="top-sales">
                            <div class="product-grid-holder">
                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="ribbon red"><span>sale</span></div>
                                        <div class="ribbon green"><span>bestseller</span></div>
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-04.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount clear"></div>
                                            <div class="title">
                                                <a href="single-product.aspx">
                                                    Netbook Acer TravelMate
                                                    B113-E-10072
                                                </a>
                                            </div>
                                            <div class="brand">acer</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-03.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount clear"></div>
                                            <div class="title">
                                                <a href="single-product.aspx">POV Action Cam</a>
                                            </div>
                                            <div class="brand">sony</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="ribbon blue"><span>new!</span></div>
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-02.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount clear"></div>
                                            <div class="title">
                                                <a href="single-product.aspx">White lumia 9001</a>
                                            </div>
                                            <div class="brand">nokia</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class="col-sm-4 col-md-3 no-margin product-item-holder hover">
                                    <div class="product-item">
                                        <div class="ribbon red"><span>sale</span></div>
                                        <div class="image">
                                            <img alt="" src="assets/images/blank.gif" data-echo="assets/images/products/product-01.jpg" />
                                        </div>
                                        <div class="body">
                                            <div class="label-discount green">-50% sale</div>
                                            <div class="title">
                                                <a href="single-product.aspx">VAIO Fit Laptop - Windows 8 SVF14322CXW</a>
                                            </div>
                                            <div class="brand">sony</div>
                                        </div>
                                        <div class="prices">
                                            <div class="price-prev">$1399.00</div>
                                            <div class="price-current pull-right">$1199.00</div>
                                        </div>
                                        <div class="hover-area">
                                            <div class="add-cart-button">
                                                <a href="single-product.aspx" class="le-button">add to cart</a>
                                            </div>
                                            <div class="wish-compare">
                                                <a class="btn-add-to-wishlist" href="#">add to wishlist</a>
                                                <a class="btn-add-to-compare" href="#">compare</a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="loadmore-holder text-center">
                                <a class="btn-loadmore" href="#">
                                    <i class="fa fa-plus"></i>
                                    load more products
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>

