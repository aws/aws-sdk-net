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

/*
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Container for the parameters to the ResetConnectorMetadataCache operation.
    /// Resets metadata about your connector entities that Amazon AppFlow stored in its cache.
    /// Use this action when you want Amazon AppFlow to return the latest information about
    /// the data that you have in a source application.
    /// 
    ///  
    /// <para>
    /// Amazon AppFlow returns metadata about your entities when you use the ListConnectorEntities
    /// or DescribeConnectorEntities actions. Following these actions, Amazon AppFlow caches
    /// the metadata to reduce the number of API requests that it must send to the source
    /// application. Amazon AppFlow automatically resets the cache once every hour, but you
    /// can use this action when you want to get the latest metadata right away.
    /// </para>
    /// </summary>
    public partial class ResetConnectorMetadataCacheRequest : AmazonAppflowRequest
    {
        private string _apiVersion;
        private string _connectorEntityName;
        private string _connectorProfileName;
        private ConnectorType _connectorType;
        private string _entitiesPath;

        /// <summary>
        /// Gets and sets the property ApiVersion. 
        /// <para>
        /// The API version that you specified in the connector profile that you’re resetting
        /// cached metadata for. You must use this parameter only if the connector supports multiple
        /// API versions or if the connector type is CustomConnector.
        /// </para>
        ///  
        /// <para>
        /// To look up how many versions a connector supports, use the DescribeConnectors action.
        /// In the response, find the value that Amazon AppFlow returns for the connectorVersion
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// To look up the connector type, use the DescribeConnectorProfiles action. In the response,
        /// find the value that Amazon AppFlow returns for the connectorType parameter.
        /// </para>
        ///  
        /// <para>
        /// To look up the API version that you specified in a connector profile, use the DescribeConnectorProfiles
        /// action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ApiVersion
        {
            get { return this._apiVersion; }
            set { this._apiVersion = value; }
        }

        // Check to see if ApiVersion property is set
        internal bool IsSetApiVersion()
        {
            return this._apiVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorEntityName. 
        /// <para>
        /// Use this parameter if you want to reset cached metadata about the details for an individual
        /// entity.
        /// </para>
        ///  
        /// <para>
        /// If you don't include this parameter in your request, Amazon AppFlow only resets cached
        /// metadata about entity names, not entity details.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ConnectorEntityName
        {
            get { return this._connectorEntityName; }
            set { this._connectorEntityName = value; }
        }

        // Check to see if ConnectorEntityName property is set
        internal bool IsSetConnectorEntityName()
        {
            return this._connectorEntityName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorProfileName. 
        /// <para>
        /// The name of the connector profile that you want to reset cached metadata for.
        /// </para>
        ///  
        /// <para>
        /// You can omit this parameter if you're resetting the cache for any of the following
        /// connectors: Amazon Connect, Amazon EventBridge, Amazon Lookout for Metrics, Amazon
        /// S3, or Upsolver. If you're resetting the cache for any other connector, you must include
        /// this parameter in your request.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ConnectorProfileName
        {
            get { return this._connectorProfileName; }
            set { this._connectorProfileName = value; }
        }

        // Check to see if ConnectorProfileName property is set
        internal bool IsSetConnectorProfileName()
        {
            return this._connectorProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectorType. 
        /// <para>
        /// The type of connector to reset cached metadata for.
        /// </para>
        ///  
        /// <para>
        /// You must include this parameter in your request if you're resetting the cache for
        /// any of the following connectors: Amazon Connect, Amazon EventBridge, Amazon Lookout
        /// for Metrics, Amazon S3, or Upsolver. If you're resetting the cache for any other connector,
        /// you can omit this parameter from your request. 
        /// </para>
        /// </summary>
        public ConnectorType ConnectorType
        {
            get { return this._connectorType; }
            set { this._connectorType = value; }
        }

        // Check to see if ConnectorType property is set
        internal bool IsSetConnectorType()
        {
            return this._connectorType != null;
        }

        /// <summary>
        /// Gets and sets the property EntitiesPath. 
        /// <para>
        /// Use this parameter only if you’re resetting the cached metadata about a nested entity.
        /// Only some connectors support nested entities. A nested entity is one that has another
        /// entity as a parent. To use this parameter, specify the name of the parent entity.
        /// </para>
        ///  
        /// <para>
        /// To look up the parent-child relationship of entities, you can send a ListConnectorEntities
        /// request that omits the entitiesPath parameter. Amazon AppFlow will return a list of
        /// top-level entities. For each one, it indicates whether the entity has nested entities.
        /// Then, in a subsequent ListConnectorEntities request, you can specify a parent entity
        /// name for the entitiesPath parameter. Amazon AppFlow will return a list of the child
        /// entities for that parent.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string EntitiesPath
        {
            get { return this._entitiesPath; }
            set { this._entitiesPath = value; }
        }

        // Check to see if EntitiesPath property is set
        internal bool IsSetEntitiesPath()
        {
            return this._entitiesPath != null;
        }

    }
}