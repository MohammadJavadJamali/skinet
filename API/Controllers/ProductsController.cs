﻿namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _productRepository;

    public ProductsController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        var products = await _productRepository.GetProductsAsync();   
        return Ok(products);    
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProduct(int id)
    {
        return await _productRepository.GetProductByIdAsync(id);
    }

    [HttpGet("brands")]
    public async Task<ActionResult<List<Product>>> GetProductBrands()
    {
        var products = await _productRepository.GetProductBrandsAsync();
        return Ok(products);
    }

    [HttpGet("types")]
    public async Task<ActionResult<List<Product>>> GetProductTypes()
    {
        var products = await _productRepository.GetProductTypesAsync();
        return Ok(products);
    }

}
