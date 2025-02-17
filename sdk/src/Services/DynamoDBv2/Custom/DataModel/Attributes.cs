﻿/*
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

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ThirdParty.RuntimeBackports;

namespace Amazon.DynamoDBv2.DataModel
{
    /// <summary>
    /// Base DynamoDB attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited=true, AllowMultiple=false)]
    public abstract class DynamoDBAttribute : Attribute
    {
    }


    /// <summary>
    /// DynamoDB attribute that marks a class.
    /// Specifies that this object can be stored in DynamoDB, the name
    /// of the target table, and if attribute names must be automatically
    /// converted to lowerCamelCase.
    /// 
    /// Need not be declared on subclasses if present on base class.
    /// Can be defined on subclasses to specify different target table
    /// or specify different attribute casing.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited=true, AllowMultiple=false)]
    public sealed class DynamoDBTableAttribute : DynamoDBAttribute
    {
        /// <summary>
        /// Gets and sets the TableName property.
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Gets and sets the LowerCamelCaseProperties property.
        /// </summary>
        public bool LowerCamelCaseProperties { get; set; }

        /// <summary>
        /// Construct an instance of DynamoDBTableAttribute
        /// </summary>
        /// <param name="tableName"></param>
        public DynamoDBTableAttribute(string tableName)
            : this(tableName, false) { }

        /// <summary>
        /// Construct an instance of DynamoDBTableAttribute
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="lowerCamelCaseProperties"></param>
        public DynamoDBTableAttribute(string tableName, bool lowerCamelCaseProperties)
        {
            TableName = tableName;
            LowerCamelCaseProperties = lowerCamelCaseProperties;
        }
    }

    /// <summary>
    /// DynamoDB attribute that marks a class or property for polymorphism support.
    /// This allows DynamoDB to store and retrieve instances of derived types 
    /// while preserving their original types during serialization and deserialization.
    /// </summary>
    /// <remarks>
    /// To enable polymorphic serialization, this attribute should be applied multiple times, 
    /// once for each possible subtype. The <see cref="TypeDiscriminator"/> serves as a unique
    /// identifier used in the database to distinguish between different derived types.
    ///
    /// The name of the stored discriminator attribute in DynamoDB can be configured via
    /// <see cref="DynamoDBContextConfig.DerivedTypeAttributeName"/>.
    /// If not explicitly set, the SDK will use a default attribute name for the discriminator.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public sealed class DynamoDBPolymorphicTypeAttribute : DynamoDBAttribute
    {
        /// <summary>
        /// Unique name discriminator of the derived type.
        /// </summary>
        /// <remarks>
        /// The <see cref="TypeDiscriminator"/> is stored in DynamoDB and is used to 
        /// determine the actual type of the object when deserializing. 
        /// It should be unique among all declared polymorphic types for a given base type.
        ///
        /// The attribute name under which this discriminator is stored in DynamoDB
        /// is configurable via <see cref="DynamoDBContextConfig.DerivedTypeAttributeName"/>.
        ///
        /// Example:
        /// <code>
        /// [DynamoDBPolymorphicType("dog", typeof(Dog))]
        /// [DynamoDBPolymorphicType("cat", typeof(Cat))]
        /// public class Animal { }
        /// </code>
        ///
        /// When retrieving an item, DynamoDB will use this discriminator value to 
        /// deserialize into the appropriate derived type.
        /// </remarks>
        public string TypeDiscriminator { get; }

        /// <summary>
        /// The specific derived type that corresponds to this polymorphic entry.
        /// </summary>
        /// <remarks>
        /// This should be a subclass of the property type where the attribute is applied. 
        /// When an instance of this type is stored in DynamoDB, the <see cref="TypeDiscriminator"/> 
        /// will be saved along with it, allowing correct type resolution during deserialization.
        /// </remarks>
        [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)]
        public Type DerivedType { get; }

        /// <summary>
        /// Constructs an instance of <see cref="DynamoDBPolymorphicTypeAttribute"/>.
        /// </summary>
        /// <param name="typeDiscriminator">
        /// A unique string identifier representing this derived type.
        /// This value is stored in DynamoDB and used for deserialization.
        /// </param>
        /// <param name="derivedType">
        /// The actual derived type that this attribute represents.
        /// Must be a subclass of the property type to which it is applied.
        /// </param>
        /// <example>
        /// Usage for a polymorphic property:
        /// <code>
        /// public class Zoo
        /// {
        ///     [DynamoDBPolymorphicType("dog", typeof(Dog))]
        ///     [DynamoDBPolymorphicType("cat", typeof(Cat))]
        ///     public Animal Resident { get; set; }
        /// }
        /// </code>
        /// 
        /// In this example, when a `Dog` instance is stored, DynamoDB will save `"dog"` as its discriminator
        /// under the attribute name configured in <see cref="DynamoDBContextConfig.DerivedTypeAttributeName"/>.
        /// When retrieved, the stored discriminator ensures that the value is deserialized as a `Dog` instance.
        /// </example>
        public DynamoDBPolymorphicTypeAttribute(string typeDiscriminator,
            [DynamicallyAccessedMembers(InternalConstants.DataModelModeledType)] Type derivedType)
        {
            TypeDiscriminator = typeDiscriminator;
            DerivedType = derivedType;
        }
    }

    /// <summary>
    /// DynamoDB attribute that directs the specified attribute not to
    /// be included when saving or loading objects.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class DynamoDBIgnoreAttribute : DynamoDBAttribute
    {
    }


    /// <summary>
    /// DynamoDB property attribute.
    /// Can be used to specify an alternative attribute name or configure
    /// a custom converter.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public abstract class DynamoDBRenamableAttribute : DynamoDBAttribute
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        protected DynamoDBRenamableAttribute()
        {
        }

        /// <summary>
        /// Constructor that specifies an alternate attribute name
        /// </summary>
        /// <param name="attributeName">
        /// Name of attribute to be associated with property or field.
        /// </param>
        protected DynamoDBRenamableAttribute(string attributeName)
        {
            AttributeName = attributeName;
        }

        /// <summary>
        /// Name of attribute that is associated with this member.
        /// </summary>
        public string AttributeName { get; set; }
    }


    /// <summary>
    /// DynamoDB property that marks up current member as item version.
    /// At most one member in a class may be marked with this attribute.
    /// 
    /// Members that are marked as version must be of primitive,
    /// numeric, integer, nullable type (e.g. int?, long?, byte?)
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class DynamoDBVersionAttribute : DynamoDBRenamableAttribute
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DynamoDBVersionAttribute()
            : base()
        {
        }

        /// <summary>
        /// Constructor that specifies an alternate attribute name
        /// </summary>
        /// <param name="attributeName">
        /// Name of attribute to be associated with property or field.
        /// </param>
        public DynamoDBVersionAttribute(string attributeName)
            : base(attributeName)
        {
        }
    }


    /// <summary>
    /// DynamoDB property attribute.
    /// Can be used to specify an alternative attribute name or configure
    /// a custom converter.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DynamoDBPropertyAttribute : DynamoDBRenamableAttribute
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DynamoDBPropertyAttribute()
            : base()
        {
        }

        /// <summary>
        /// Constructor that specifies an alternate attribute name
        /// </summary>
        /// <param name="attributeName">
        /// Name of attribute to be associated with property or field.
        /// </param>
        public DynamoDBPropertyAttribute(string attributeName)
            : base(attributeName)
        {
        }

        /// <summary>
        /// Constructor that specifies a custom converter.
        /// 
        /// Converter must be the type of a class that implements IPropertyConverter.
        /// </summary>
        /// <param name="converter">Custom converter type.</param>
        public DynamoDBPropertyAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.Interfaces)] Type converter)
        {
            Converter = converter;
        }

        /// <summary>
        /// Constructor that specifies that this type should be stored as epoch seconds.
        /// </summary>
        /// <param name="storeAsEpoch">
        /// Whether the data should be stored as epoch seconds.
        /// If false, data is stored as ISO-8601 string.
        /// </param>
        public DynamoDBPropertyAttribute(bool storeAsEpoch)
        {
            StoreAsEpoch = storeAsEpoch;
        }


        /// <summary>
        /// Constructor that specifies an alternate attribute name and a custom converter.
        /// 
        /// Converter must be the type of a class that implements IPropertyConverter.
        /// </summary>
        /// <param name="attributeName">
        /// Name of attribute to be associated with property or field.
        /// </param>
        /// <param name="converter">Custom converter type.</param>
        public DynamoDBPropertyAttribute(string attributeName, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.Interfaces)] Type converter)
            : base(attributeName)
        {
            Converter = converter;
        }

        /// <summary>
        /// Constructor that specifies an alternate attribute name and that this type should
        /// be stored as epoch seconds.
        /// </summary>
        /// <param name="attributeName">
        /// Name of attribute to be associated with property or field.
        /// </param>
        /// <param name="storeAsEpoch">
        /// Whether the data should be stored as epoch seconds.
        /// If false, data is stored as ISO-8601 string.
        /// </param>
        public DynamoDBPropertyAttribute(string attributeName, bool storeAsEpoch)
            : base(attributeName)
        {
            StoreAsEpoch = storeAsEpoch;
        }

        /// <summary>
        /// Type of the custom converter.
        /// Cannot be set at the same time as StoreAsEpoch.
        /// </summary>
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.Interfaces)]
        public Type Converter { get; set; }

        /// <summary>
        /// Flag that directs DynamoDBContext to store this data as epoch seconds integer.
        /// If false, data is stored as ISO-8601 string.
        /// Cannot be set at the same time as Converter.
        /// </summary>
        public bool StoreAsEpoch { get; set; }
    }

    /// <summary>
    /// DynamoDB property that marks up current member as a hash key element.
    /// Exactly one member in a class must be marked with this attribute.
    /// 
    /// Members that are marked as a hash key must be convertible to
    /// a Primitive object.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DynamoDBHashKeyAttribute : DynamoDBPropertyAttribute
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DynamoDBHashKeyAttribute()
            : base()
        {
        }

        /// <summary>
        /// Constructor that specifies an alternate attribute name
        /// </summary>
        /// <param name="attributeName">
        /// Name of attribute to be associated with property or field.
        /// </param>
        public DynamoDBHashKeyAttribute(string attributeName)
            : base(attributeName)
        {
        }

        /// <summary>
        /// Constructor that specifies a custom converter.
        /// 
        /// Converter must be the type of a class that implements IPropertyConverter.
        /// </summary>
        /// <param name="converter">Custom converter type.</param>
        public DynamoDBHashKeyAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.Interfaces)] Type converter)
            : base(converter)
        {
        }

        /// <summary>
        /// Constructor that specifies an alternate attribute name and a custom converter.
        /// 
        /// Converter must be the type of a class that implements IPropertyConverter.
        /// </summary>
        /// <param name="attributeName">
        /// Name of attribute to be associated with property or field.
        /// </param>
        /// <param name="converter">Custom converter type.</param>
        public DynamoDBHashKeyAttribute(string attributeName, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.Interfaces)] Type converter)
            : base(attributeName, converter)
        {
        }
    }

    /// <summary>
    /// DynamoDB property that marks up current member as range key element (for a hash-and-range primary key).
    /// At most one member in a class may be marked with this attribute.
    /// 
    /// Members that are marked as a range key element must be convertible to
    /// a Primitive object.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DynamoDBRangeKeyAttribute : DynamoDBPropertyAttribute
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DynamoDBRangeKeyAttribute()
            : base()
        {
        }

        /// <summary>
        /// Constructor that specifies an alternate attribute name
        /// </summary>
        /// <param name="attributeName">
        /// Name of attribute to be associated with property or field.
        /// </param>
        public DynamoDBRangeKeyAttribute(string attributeName)
            : base(attributeName)
        {
        }

        /// <summary>
        /// Constructor that specifies a custom converter.
        /// 
        /// Converter must be the type of a class that implements IPropertyConverter.
        /// </summary>
        /// <param name="converter">Custom converter type.</param>
        public DynamoDBRangeKeyAttribute([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.Interfaces)] Type converter)
            : base(converter)
        {
        }

        /// <summary>
        /// Constructor that specifies an alternate attribute name and a custom converter.
        /// 
        /// Converter must be the type of a class that implements IPropertyConverter.
        /// </summary>
        /// <param name="attributeName">
        /// Name of attribute to be associated with property or field.
        /// </param>
        /// <param name="converter">Custom converter type.</param>
        public DynamoDBRangeKeyAttribute(string attributeName, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.Interfaces)] Type converter)
            : base(attributeName, converter)
        {
        }
    }


    /// DynamoDB property attribute that marks up current member as a hash key element for a Global Secondary Index on a table.
    /// 
    /// Members that are marked as a Global Secondary Index hash key element must be convertible to a Primitive object.
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DynamoDBGlobalSecondaryIndexHashKeyAttribute : DynamoDBHashKeyAttribute
    {
        /// <summary>
        /// Indexes associated with this hash key.
        /// </summary>
        public string[] IndexNames { get; set; }

        /// <summary>
        /// Constructor that accepts a single index name.
        /// </summary>
        /// <param name="indexName">Name of the Global Secondary Index this hash key belongs to.</param>
        public DynamoDBGlobalSecondaryIndexHashKeyAttribute(string indexName)
            : base()
        {
            IndexNames = new string[] { indexName };
        }

        /// <summary>
        /// Constructor that accepts multiple index names.
        /// </summary>
        /// <param name="indexNames">Names of the Global Secondary Indexes this hash key belongs to.</param>
        public DynamoDBGlobalSecondaryIndexHashKeyAttribute(params string[] indexNames)
            : base()
        {
            IndexNames = indexNames.Distinct(StringComparer.Ordinal).ToArray();
        }
    }

    /// DynamoDB property attribute that marks up current member as range key element for a Global Secondary Index on a table.
    /// 
    /// Members that are marked as a Global Secondary Index range key element must be convertible to a Primitive object.
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DynamoDBGlobalSecondaryIndexRangeKeyAttribute : DynamoDBRangeKeyAttribute
    {
        /// <summary>
        /// Indexes associated with this range key.
        /// </summary>
        public string[] IndexNames { get; set; }

        /// <summary>
        /// Constructor that accepts a single index name.
        /// </summary>
        /// <param name="indexName">Name of the Global Secondary Index this range key belongs to.</param>
        public DynamoDBGlobalSecondaryIndexRangeKeyAttribute(string indexName)
            : base()
        {
            IndexNames = new string[] { indexName };
        }

        /// <summary>
        /// Constructor that accepts multiple index names.
        /// </summary>
        /// <param name="indexNames">Names of the Global Secondary Indexes this range key belongs to.</param>
        public DynamoDBGlobalSecondaryIndexRangeKeyAttribute(params string[] indexNames)
            : base()
        {
            IndexNames = indexNames.Distinct(StringComparer.Ordinal).ToArray();
        }
    }


    /// <summary>
    /// DynamoDB property that marks up current member as range key element for a Local Secondary Index on a table.
    /// 
    /// Members that are marked as a Local Secondary Index range key element must be convertible to a Primitive object.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class DynamoDBLocalSecondaryIndexRangeKeyAttribute : DynamoDBPropertyAttribute
    {
        /// <summary>
        /// Indexes associated with this range key.
        /// </summary>
        public string[] IndexNames { get; set; }

        /// <summary>
        /// Constructor that accepts a single index name.
        /// </summary>
        /// <param name="indexName">Name of the Local Secondary Index this range key belongs to.</param>
        public DynamoDBLocalSecondaryIndexRangeKeyAttribute(string indexName)
            : base()
        {
            IndexNames = new string[] { indexName };
        }

        /// <summary>
        /// Constructor that accepts multiple index names.
        /// </summary>
        /// <param name="indexNames">Names of the Local Secondary Indexes this range key belongs to.</param>
        public DynamoDBLocalSecondaryIndexRangeKeyAttribute(params string[] indexNames)
            : base()
        {
            IndexNames = indexNames.Distinct(StringComparer.Ordinal).ToArray();
        }
    }
}
