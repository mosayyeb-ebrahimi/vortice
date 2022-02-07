// Copyright � Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

namespace Vortice.Graphics;

/// <summary>
/// Structure that describes the <see cref="Texture"/>.
/// </summary>
public record struct BufferDescriptor : IEquatable<BufferDescriptor>
{
    public BufferDescriptor(BufferUsage usage, ulong size, string? label = default)
    {
        Usage = usage;
        Size = size;
        Label = label;
    }

    /// <summary>
    /// <see cref="BufferUsage"/> of <see cref="Buffer"/>.
    /// </summary>
    public BufferUsage Usage { get; init; }

    /// <summary>
    /// Size in bytes of <see cref="Buffer"/>
    /// </summary>
    public ulong Size { get; init; }

    public string? Label { get; init; }
}