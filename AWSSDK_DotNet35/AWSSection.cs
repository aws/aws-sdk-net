/*******************************************************************************
 *  Copyright 2008-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */

using System;
using System.Collections.Specialized;
using System.ComponentModel;

using System.Configuration;

using Amazon.Util;
using System.Xml;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

namespace Amazon
{
    /// <summary>
    /// Root AWS config section
    /// </summary>
    internal class AWSSection : ConfigurationSection
    {
        private const string loggingKey = "logging";
        private const string dynamoDBKey = "dynamoDB";
        private const string s3Key = "s3";
        private const string ec2Key = "ec2";
        private const string defaultsKey = "defaults";
        private const string endpointDefinitionKey = "endpointDefinition";
        private const string regionKey = "region";
        private const string proxy = "proxy";
        private const string profileNameKey = "profileName";
        private const string profilesLocationKey = "profilesLocation";
        private const string correctForClockSkewKey = "correctForClockSkew";

        [ConfigurationProperty(loggingKey)]
        public LoggingSection Logging
        {
            get { return (LoggingSection)this[loggingKey]; }
            set { this[loggingKey] = value; }
        }

        [ConfigurationProperty(dynamoDBKey)]
        public DynamoDBSection DynamoDB
        {
            get { return (DynamoDBSection)this[dynamoDBKey]; }
            set { this[dynamoDBKey] = value; }
        }

        [ConfigurationProperty(s3Key)]
        public V4ClientSection S3
        {
            get { return (V4ClientSection)this[s3Key]; }
            set { this[s3Key] = value; }
        }

        [ConfigurationProperty(ec2Key)]
        public V4ClientSection EC2
        {
            get { return (V4ClientSection)this[ec2Key]; }
            set { this[ec2Key] = value; }
        }

        [ConfigurationProperty(endpointDefinitionKey)]
        public string EndpointDefinition
        {
            get { return (string)this[endpointDefinitionKey]; }
            set { this[endpointDefinitionKey] = value; }
        }

        [ConfigurationProperty(regionKey)]
        public string Region
        {
            get { return (string)this[regionKey]; }
            set { this[regionKey] = value; }
        }

        [ConfigurationProperty(profileNameKey)]
        public string ProfileName
        {
            get { return (string)this[profileNameKey]; }
            set { this[profileNameKey] = value; }
        }

        [ConfigurationProperty(profilesLocationKey)]
        public string ProfilesLocation
        {
            get { return (string)this[profilesLocationKey]; }
            set { this[profilesLocationKey] = value; }
        }

        [ConfigurationProperty(correctForClockSkewKey)]
        public bool? CorrectForClockSkew
        {
            get { return (bool?)this[correctForClockSkewKey]; }
            set { this[correctForClockSkewKey] = value; }
        }

        /// <summary>
        /// Gets and sets the proxy settings for the SDK to use.
        /// </summary>
        [ConfigurationProperty(proxy)]
        public ProxySection Proxy
        {
            get { return (ProxySection)this[proxy]; }
            set { this[proxy] = value; }
        }

        internal string Serialize(string name)
        {
            try
            {
                string basicXml = this.SerializeSection(null, name, ConfigurationSaveMode.Full);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(basicXml);
                using (var textWriter = new StringWriter(CultureInfo.InvariantCulture))
                {
                    CleanUpNodes(doc);

                    doc.Save(textWriter);
                    return textWriter.ToString();
                }
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        internal static void CleanUpNodes(XmlNode node)
        {
            foreach (XmlNode child in node.ChildNodes)
            {
                var toRemove = child.Attributes.Cast<XmlAttribute>().Where(at => string.IsNullOrEmpty(at.Value)).ToList();
                foreach (var rem in toRemove) child.Attributes.Remove(rem);

                CleanUpNodes(child);
            }
        }

        public override bool IsReadOnly()
        {
            return false;
        }
    }

    #region Basic sections

    /// <summary>
    /// V4-enabling section
    /// </summary>
    internal class V4ClientSection : WritableConfigurationElement
    {
        private const string useSignatureVersion4Key = "useSignatureVersion4";

        [ConfigurationProperty(useSignatureVersion4Key)]
        public bool? UseSignatureVersion4
        {
            get { return (bool?)this[useSignatureVersion4Key]; }
            set { this[useSignatureVersion4Key] = value; }
        }
    }

    /// <summary>
    /// Settings for configuring a proxy for the SDK to use.
    /// </summary>
    internal class ProxySection : WritableConfigurationElement
    {
        private const string hostSection = "host";
        private const string portSection = "port";
        private const string usernameSection = "username";
        private const string passwordSection = "password";

        /// <summary>
        /// Gets and sets the host name or IP address of the proxy server.
        /// </summary>
        [ConfigurationProperty(hostSection)]
        public string Host
        {
            get { return (string)this[hostSection]; }
            set { this[hostSection] = value; }
        }

        /// <summary>
        /// Gets and sets the port number of the proxy.
        /// </summary>
        [ConfigurationProperty(portSection)]
        public int? Port
        {
            get { return (int?)this[portSection]; }
            set { this[portSection] = value; }
        }

        /// <summary>
        /// Gets and sets the username to authenticate with the proxy server.
        /// </summary>
        [ConfigurationProperty(usernameSection)]
        public string Username
        {
            get { return (string)this[usernameSection]; }
            set { this[usernameSection] = value; }
        }

        /// <summary>
        /// Gets and sets the password to authenticate with the proxy server.
        /// </summary>
        [ConfigurationProperty(passwordSection)]
        public string Password
        {
            get { return (string)this[passwordSection]; }
            set { this[passwordSection] = value; }
        }

    }

    /// <summary>
    /// Logging section
    /// </summary>
    internal class LoggingSection : WritableConfigurationElement
    {
        private const string logToKey = "logTo";
        private const string logResponsesKey = "logResponses";
        private const string logMetricsKey = "logMetrics";
        private const string logMetricsFormatKey = "logMetricsFormat";
        private const string logMetricsCustomFormatterKey = "logMetricsCustomFormatter";

        [ConfigurationProperty(logToKey)]
        public LoggingOptions LogTo
        {
            get { return (LoggingOptions)this[logToKey]; }
            set { this[logToKey] = value; }
        }

        [ConfigurationProperty(logResponsesKey)]
        public ResponseLoggingOption LogResponses
        {
            get { return (ResponseLoggingOption)this[logResponsesKey]; }
            set { this[logResponsesKey] = value; }
        }

        [ConfigurationProperty(logMetricsKey)]
        public bool? LogMetrics
        {
            get { return (bool?)this[logMetricsKey]; }
            set { this[logMetricsKey] = value; }
        }

        [ConfigurationProperty(logMetricsFormatKey)]
        public LogMetricsFormatOption LogMetricsFormat
        {
            get { return (LogMetricsFormatOption)this[logMetricsFormatKey]; }
            set { this[logMetricsFormatKey] = value; }
        }

        [TypeConverter(typeof(TypeNameConverter))]
        [ConfigurationProperty(logMetricsCustomFormatterKey)]
        public Type LogMetricsCustomFormatter
        {
            get { return (Type)this[logMetricsCustomFormatterKey]; }
            set { this[logMetricsCustomFormatterKey] = value; }
        }
    }

    #endregion

    #region DynamoDB sections

    /// <summary>
    /// Root DynamoDB section
    /// </summary>
    internal class DynamoDBSection : WritableConfigurationElement
    {
        private const string contextKey = "dynamoDBContext";
        private const string conversionKey = "conversionSchema";

        [ConfigurationProperty(contextKey)]
        public DynamoDBContextSection Context
        {
            get { return (DynamoDBContextSection)this[contextKey]; }
            set { this[contextKey] = value; }
        }

        [ConfigurationProperty(conversionKey)]
        public ConversionSchema ConversionSchema
        {
            get { return (ConversionSchema)this[conversionKey]; }
            set { this[conversionKey] = value; }
        }

    }

    /// <summary>
    /// DynamoDBContext section
    /// </summary>
    internal class DynamoDBContextSection : WritableConfigurationElement
    {
        private const string tableNamePrefixKey = "tableNamePrefix";
        private const string tableAliasesKey = "tableAliases";
        private const string mappingsKey = "mappings";

        [ConfigurationProperty(tableNamePrefixKey)]
        public string TableNamePrefix
        {
            get { return (string)this[tableNamePrefixKey]; }
            set { this[tableNamePrefixKey] = value; }
        }

        [ConfigurationProperty(tableAliasesKey)]
        public TableAliasesCollection TableAliases
        {
            get { return (TableAliasesCollection)this[tableAliasesKey]; }
            set { this[tableAliasesKey] = value; }
        }

        [ConfigurationProperty(mappingsKey)]
        public TypeMappingsCollection TypeMappings
        {
            get { return (TypeMappingsCollection)this[mappingsKey]; }
            set { this[mappingsKey] = value; }
        }
    }

    /// <summary>
    /// Single DDB table alias
    /// </summary>
    internal class TableAliasElement : SerializableConfigurationElement
    {
        private const string fromTableKey = "fromTable";
        private const string toTableKey = "toTable";

        [ConfigurationProperty(fromTableKey)]
        public string FromTable
        {
            get { return (string)this[fromTableKey]; }
            set { this[fromTableKey] = value; }
        }

        [ConfigurationProperty(toTableKey, IsRequired = true)]
        public string ToTable
        {
            get { return (string)this[toTableKey]; }
            set { this[toTableKey] = value; }
        }

        public TableAliasElement() { }

        public TableAliasElement(string fromTable, string toTable)
        {
            FromTable = fromTable;
            ToTable = toTable;
        }
    }

    /// <summary>
    /// Collection of DDB table aliases
    /// </summary>
    [ConfigurationCollection(typeof(TableAliasElement))]
    internal class TableAliasesCollection : WritableConfigurationElementCollection<TableAliasElement>
    {
        protected override string ItemPropertyName { get { return "alias"; } }

        public TableAliasesCollection() : base() { }
        public TableAliasesCollection(params TableAliasElement[] remaps) : base()
        {
            if (remaps != null)
                Add(remaps);
        }
    }

    /// <summary>
    /// Single DDB type mapping config
    /// </summary>
    internal class TypeMappingElement : SerializableConfigurationElement
    {
        private const string typeKey = "type";
        private const string targetTableKey = "targetTable";
        private const string itemKey = "";

        [TypeConverter(typeof(TypeNameConverter))]
        [ConfigurationProperty(typeKey, IsRequired = true)]
        public Type Type
        {
            get { return (Type)this[typeKey]; }
            set { this[typeKey] = value; }
        }

        [ConfigurationProperty(targetTableKey, IsRequired = true)]
        public string TargetTable
        {
            get { return (string)this[targetTableKey]; }
            set { this[targetTableKey] = value; }
        }

        [ConfigurationProperty(itemKey, IsDefaultCollection = true)]
        public PropertyConfigsCollection PropertyConfigs
        {
            get { return (PropertyConfigsCollection)this[itemKey]; }
            set { this[itemKey] = value; }
        }
    }

    /// <summary>
    /// Collection of DDB type mapping configs
    /// </summary>
    [ConfigurationCollection(typeof(TypeMappingElement))]
    internal class TypeMappingsCollection : WritableConfigurationElementCollection<TypeMappingElement>
    {
        protected override string ItemPropertyName { get { return "map"; } }

        public TypeMappingsCollection() : base() { }
        public TypeMappingsCollection(params TypeMappingElement[] mappings) : base()
        {
            if (mappings != null)
                Add(mappings);
        }
    }

    /// <summary>
    /// Single DDB property mapping config
    /// </summary>
    internal class PropertyConfigElement : SerializableConfigurationElement
    {
        private const string nameKey = "name";
        private const string attributeKey = "attribute";
        private const string ignoreKey = "ignore";
        private const string versionKey = "version";
        private const string converterKey = "converter";

        [ConfigurationProperty(nameKey, IsRequired = true)]
        public string Name
        {
            get { return (string)this[nameKey]; }
            set { this[nameKey] = value; }
        }

        [ConfigurationProperty(attributeKey)]
        public string Attribute
        {
            get { return (string)this[attributeKey]; }
            set { this[attributeKey] = value; }
        }

        [ConfigurationProperty(ignoreKey)]
        public bool? Ignore
        {
            get { return (bool?)this[ignoreKey]; }
            set { this[ignoreKey] = value; }
        }

        [ConfigurationProperty(versionKey)]
        public bool? Version
        {
            get { return (bool?)this[versionKey]; }
            set { this[versionKey] = value; }
        }

        [TypeConverter(typeof(TypeNameConverter))]
        [ConfigurationProperty(converterKey)]
        public Type Converter
        {
            get { return (Type)this[converterKey]; }
            set { this[converterKey] = value; }
        }
    }

    /// <summary>
    /// Collection of DDB property mapping configs
    /// </summary>
    [ConfigurationCollection(typeof(PropertyConfigElement))]
    internal class PropertyConfigsCollection : WritableConfigurationElementCollection<PropertyConfigElement>
    {
        protected override string ItemPropertyName { get { return "property"; } }

        public PropertyConfigsCollection() : base() { }
        public PropertyConfigsCollection(params PropertyConfigElement[] configs) : base()
        {
            if (configs != null)
                Add(configs);
        }
    }

    #endregion

    #region Abstract helper classes

    /// <summary>
    /// Easy-to-use generic collection
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal abstract class WritableConfigurationElementCollection<T> : ConfigurationElementCollection
    where T : SerializableConfigurationElement, new()
    {
        protected abstract string ItemPropertyName { get; }

        protected override ConfigurationElement CreateNewElement()
        {
            return new T();
        }
        protected override ConfigurationElement CreateNewElement(string elementName)
        {
            return new T();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return element;
        }
        protected override string ElementName { get { return string.Empty; } }
        protected override bool IsElementName(string elementName)
        {
            return (string.Equals(elementName, ItemPropertyName, StringComparison.Ordinal));
        }
        public override ConfigurationElementCollectionType CollectionType { get { return ConfigurationElementCollectionType.BasicMapAlternate; } }
        public override bool IsReadOnly()
        {
            return false;
        }

        public WritableConfigurationElementCollection() : base() { }

        public void Add(T t)
        {
            this.BaseAdd(t);
        }
        public void Add(T[] ts)
        {
            foreach (var t in ts)
            {
                Add(t);
            }
        }

        protected override bool SerializeElement(XmlWriter writer, bool serializeCollectionKey)
        {
            if (writer == null)
                return base.SerializeElement(writer, serializeCollectionKey);

            for (int i = 0; i < this.Count; i++)
            {
                var item = BaseGet(i) as SerializableConfigurationElement;
                writer.WriteStartElement(ItemPropertyName);
                item.SerializeElement(writer, serializeCollectionKey);
                writer.WriteEndElement();
            }

            return (Count > 0);
        }

        public List<T> Items { get { return this.Cast<T>().ToList(); } }
    }

    /// <summary>
    /// Configuration element that serializes properly when used with collections
    /// </summary>
    internal abstract class SerializableConfigurationElement : WritableConfigurationElement
    {
        new public bool SerializeElement(XmlWriter writer, bool serializeCollectionKey)
        {
            return base.SerializeElement(writer, serializeCollectionKey);
        }
    }

    /// <summary>
    /// ConfigurationElement class which returns false for IsReadOnly
    /// </summary>
    internal abstract class WritableConfigurationElement : ConfigurationElement
    {
        public override bool IsReadOnly()
        {
            return false;
        }
    }

    #endregion
}
