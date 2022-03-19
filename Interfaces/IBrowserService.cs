﻿namespace Interfaces;

public interface IBrowserService
{
    Task<BrowserDimension> GetDimensions();
    ValueTask Resize();
    ValueTask OnWindowSize();
}
