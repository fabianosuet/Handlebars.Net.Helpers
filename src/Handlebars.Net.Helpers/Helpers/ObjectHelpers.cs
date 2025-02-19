﻿using HandlebarsDotNet.Helpers.Attributes;
using HandlebarsDotNet.Helpers.Enums;

namespace HandlebarsDotNet.Helpers.Helpers;

internal class ObjectHelpers : BaseHelpers, IHelpers
{
    public ObjectHelpers(IHandlebars context) : base(context)
    {
    }

    [HandlebarsWriter(WriterType.Value)]
    public object? FormatAsObject(object? value)
    {
        return value;
    }

    [HandlebarsWriter(WriterType.String)]
    public string ToString(object? value)
    {
        return value?.ToString() ?? string.Empty;
    }

    public Category Category => Category.Object;
}