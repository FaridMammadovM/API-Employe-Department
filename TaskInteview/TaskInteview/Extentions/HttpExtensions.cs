﻿using Microsoft.AspNetCore.Http;
using System.Text.Json;
using TaskInteview.Helpers;

namespace TaskInteview.Extentions
{
    public static class HttpExtensions
    {

        public static void AddPaginationHeader(this HttpResponse response, int currentPage,
             int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationHeader));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");

        }
    }
}
