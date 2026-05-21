/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

namespace AWSSDK.Benchmarks.Serde;

/// <summary>
/// Shared helpers for constructing test data across protocols.
/// Provides factory methods for creating DynamoDB-like items at various sizes
/// and CloudWatch-like metric data at various sizes.
/// </summary>
public static class TestDataHelpers
{
    /// <summary>Creates a DynamoDB item with a single string key (Baseline).</summary>
    public static Dictionary<string, T> CreateBaselineItem<T>(Func<string, T> stringAttr)
    {
        return new Dictionary<string, T>
        {
            ["pk"] = stringAttr("baseline-key")
        };
    }

    /// <summary>Creates a small DynamoDB item with a few string attributes.</summary>
    public static Dictionary<string, T> CreateSmallItem<T>(Func<string, T> stringAttr, Func<double, T> numberAttr, Func<bool, T> boolAttr)
    {
        return new Dictionary<string, T>
        {
            ["pk"] = stringAttr("item-001"),
            ["sk"] = stringAttr("sort-key-001"),
            ["name"] = stringAttr("Test Item"),
            ["count"] = numberAttr(42),
            ["active"] = boolAttr(true)
        };
    }

    /// <summary>Creates a medium DynamoDB item with ~20 attributes of mixed types.</summary>
    public static Dictionary<string, T> CreateMediumItem<T>(
        Func<string, T> stringAttr, Func<double, T> numberAttr, Func<bool, T> boolAttr,
        Func<List<T>, T> listAttr, Func<Dictionary<string, T>, T> mapAttr)
    {
        var item = new Dictionary<string, T>
        {
            ["pk"] = stringAttr("item-001"),
            ["sk"] = stringAttr("sort-key-001"),
            ["name"] = stringAttr("Medium Test Item with a longer name for benchmarking"),
            ["description"] = stringAttr("This is a medium-sized item used for serde performance benchmarking across AWS SDK protocols."),
            ["count"] = numberAttr(12345),
            ["price"] = numberAttr(99.99),
            ["active"] = boolAttr(true),
            ["verified"] = boolAttr(false),
            ["category"] = stringAttr("electronics"),
            ["subcategory"] = stringAttr("smartphones"),
            ["brand"] = stringAttr("TestBrand"),
            ["model"] = stringAttr("TB-2024-Pro"),
            ["color"] = stringAttr("midnight-blue"),
            ["weight"] = numberAttr(0.185),
            ["rating"] = numberAttr(4.7),
        };
        item["tags"] = listAttr(new List<T>
        {
            stringAttr("sale"), stringAttr("new"), stringAttr("featured"), stringAttr("popular"), stringAttr("recommended")
        });
        item["metadata"] = mapAttr(new Dictionary<string, T>
        {
            ["createdAt"] = stringAttr("2024-01-15T10:30:00Z"),
            ["updatedAt"] = stringAttr("2024-06-20T14:45:00Z"),
            ["version"] = numberAttr(3),
            ["source"] = stringAttr("api")
        });
        return item;
    }

    /// <summary>Creates a large DynamoDB item with ~50 attributes including nested structures.</summary>
    public static Dictionary<string, T> CreateLargeItem<T>(
        Func<string, T> stringAttr, Func<double, T> numberAttr, Func<bool, T> boolAttr,
        Func<List<T>, T> listAttr, Func<Dictionary<string, T>, T> mapAttr)
    {
        var item = CreateMediumItem(stringAttr, numberAttr, boolAttr, listAttr, mapAttr);
        // Add more attributes to make it large
        for (int i = 0; i < 30; i++)
        {
            item[$"attr_{i:D3}"] = stringAttr($"value-{i}-{new string('x', 50)}");
        }
        item["nestedMap"] = mapAttr(new Dictionary<string, T>
        {
            ["level1a"] = mapAttr(new Dictionary<string, T>
            {
                ["level2a"] = stringAttr("deep-value-a"),
                ["level2b"] = numberAttr(999),
                ["level2c"] = boolAttr(true)
            }),
            ["level1b"] = listAttr(new List<T>
            {
                stringAttr("list-item-1"), stringAttr("list-item-2"), stringAttr("list-item-3"),
                stringAttr("list-item-4"), stringAttr("list-item-5"), stringAttr("list-item-6"),
                stringAttr("list-item-7"), stringAttr("list-item-8"), stringAttr("list-item-9"),
                stringAttr("list-item-10")
            })
        });
        return item;
    }

    /// <summary>Creates a DynamoDB item with binary data of the specified size.</summary>
    public static Dictionary<string, T> CreateBinaryItem<T>(Func<string, T> stringAttr, Func<MemoryStream, T> binaryAttr, int binarySize)
    {
        var binaryData = new byte[binarySize];
        Random.Shared.NextBytes(binaryData);
        return new Dictionary<string, T>
        {
            ["pk"] = stringAttr("binary-item"),
            ["data"] = binaryAttr(new MemoryStream(binaryData))
        };
    }

    /// <summary>Creates a shallow map with many top-level keys.</summary>
    public static Dictionary<string, T> CreateShallowMapItem<T>(Func<string, T> stringAttr, int keyCount)
    {
        var item = new Dictionary<string, T> { ["pk"] = stringAttr("shallow-map-item") };
        for (int i = 0; i < keyCount; i++)
        {
            item[$"key_{i:D4}"] = stringAttr($"value-{i}");
        }
        return item;
    }

    /// <summary>Creates a nested item with specified depth.</summary>
    public static Dictionary<string, T> CreateNestedItem<T>(
        Func<string, T> stringAttr, Func<Dictionary<string, T>, T> mapAttr, int depth)
    {
        var item = new Dictionary<string, T> { ["pk"] = stringAttr("nested-item") };
        var current = item;
        for (int i = 0; i < depth; i++)
        {
            var nested = new Dictionary<string, T>
            {
                [$"level_{i}"] = stringAttr($"value-at-depth-{i}")
            };
            current[$"nested_{i}"] = mapAttr(nested);
            current = nested;
        }
        return item;
    }

    // Size constants matching the Smithy model payload sizes
    public const int SmallBinarySize = 256;          // ~256 bytes
    public const int MediumBinarySize = 32 * 1024;   // ~32 KiB
    public const int LargeBinarySize = 256 * 1024;   // ~256 KiB

    public const int SmallShallowMapKeys = 5;
    public const int MediumShallowMapKeys = 50;
    public const int LargeShallowMapKeys = 500;

    public const int MediumNestingDepth = 5;
    public const int LargeNestingDepth = 15;
}
