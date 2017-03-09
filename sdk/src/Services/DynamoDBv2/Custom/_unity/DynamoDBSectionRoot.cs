using Amazon.DynamoDBv2;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Amazon.Util
{
    internal class DynamoDBSectionRoot
    {
        private const string dynamoDBKey = "dynamoDB";

        public DynamoDBSectionRoot(XElement section)
        {
           this.DynamoDB = AWSConfigs.GetObject<DynamoDBSection>(section, dynamoDBKey);
        }

        public DynamoDBSection DynamoDB { get; private set; }
    }

    /// <summary>
    /// Root DynamoDB section
    /// </summary>
    internal class DynamoDBSection : ConfigurationElement
    {
        public DynamoDBContextSection DynamoDBContext { get; private set; }

        /// <summary>
        /// Alternate property for DynamoDBSection.DynamoDBContext, this
        /// property is referred by AWSConfigsDynamoDB to load values.
        /// </summary>
        public DynamoDBContextSection Context { get { return this.DynamoDBContext; } }

        public ConversionSchema ConversionSchema { get; private set; }
    }

    /// <summary>
    /// DynamoDBContext section
    /// </summary>
    internal class DynamoDBContextSection : ConfigurationElement
    {
        public DynamoDBContextSection()
        {
            this.TableAliases = new TableAliasesCollection();
            this.Mappings = new TypeMappingsCollection();
        }

        public string TableNamePrefix { get; private set; }

        public TableAliasesCollection TableAliases { get; private set; }

        public TypeMappingsCollection Mappings { get; private set; }

        /// <summary>
        /// Alternate property for DynamoDBContextSection.Mappings, this
        /// property is referred by DynamoDBContextConfig to load values.
        /// </summary>
        public TypeMappingsCollection TypeMappings { get { return this.Mappings; } }
    }

    /// <summary>
    /// Single DDB table alias
    /// </summary>
    internal class TableAliasElement : ConfigurationElement
    {        
        public string FromTable { get; private set; }

        public string ToTable { get; private set; }
    }

    /// <summary>
    /// Collection of DDB table aliases
    /// </summary>
    internal class TableAliasesCollection : ConfigurationList<TableAliasElement>
    {
        public string ItemPropertyName { get { return "alias"; } }
    }

    /// <summary>
    /// Single DDB type mapping config
    /// </summary>
    internal class TypeMappingElement : ConfigurationElement
    {
        public TypeMappingElement()
        {
            this.PropertyConfigs = new PropertyConfigsCollection();
        }

        public Type Type { get; private set; }

        public string TargetTable { get; private set; }

        public PropertyConfigsCollection PropertyConfigs { get; private set; }
    }

    /// <summary>
    /// Collection of DDB type mapping configs
    /// </summary>
    internal class TypeMappingsCollection : ConfigurationList<TypeMappingElement>
    {
        public string ItemPropertyName { get { return "map"; } }
    }

    /// <summary>
    /// Single DDB property mapping config
    /// </summary>
    internal class PropertyConfigElement : ConfigurationElement
    {
        public string Name { get; private set; }

        public string Attribute { get; private set; }

        public bool? Ignore { get; private set; }

        public bool? Version { get; private set; }

        public Type Converter { get; private set; }

        public bool? StoreAsEpoch { get; set; }
    }

    /// <summary>
    /// Collection of DDB property mapping configs
    /// </summary>
    internal class PropertyConfigsCollection : ConfigurationList<PropertyConfigElement>
    {
        public string ItemPropertyName { get { return "property"; } }
    }
}
