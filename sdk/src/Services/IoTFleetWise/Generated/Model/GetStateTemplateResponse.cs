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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// This is the response object from the GetStateTemplate operation.
    /// </summary>
    public partial class GetStateTemplateResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private List<string> _dataExtraDimensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _id;
        private DateTime? _lastModificationTime;
        private List<string> _metadataExtraDimensions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private string _signalCatalogArn;
        private List<string> _stateTemplateProperties = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the state template.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the state template was created in seconds since epoch (January 1, 1970 at
        /// midnight UTC time).
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataExtraDimensions. 
        /// <para>
        /// A list of vehicle attributes associated with the payload published on the state template's
        /// MQTT topic. 
        /// </para>
        ///  
        /// <para>
        /// Default: An empty array
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> DataExtraDimensions
        {
            get { return this._dataExtraDimensions; }
            set { this._dataExtraDimensions = value; }
        }

        // Check to see if DataExtraDimensions property is set
        internal bool IsSetDataExtraDimensions()
        {
            return this._dataExtraDimensions != null && (this._dataExtraDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the state template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the state template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=26, Max=26)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The time the state template was last updated in seconds since epoch (January 1, 1970
        /// at midnight UTC time).
        /// </para>
        /// </summary>
        public DateTime? LastModificationTime
        {
            get { return this._lastModificationTime; }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataExtraDimensions. 
        /// <para>
        /// A list of vehicle attributes to associate with user properties of the messages published
        /// on the state template's MQTT topic.
        /// </para>
        ///  
        /// <para>
        /// Default: An empty array
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> MetadataExtraDimensions
        {
            get { return this._metadataExtraDimensions; }
            set { this._metadataExtraDimensions = value; }
        }

        // Check to see if MetadataExtraDimensions property is set
        internal bool IsSetMetadataExtraDimensions()
        {
            return this._metadataExtraDimensions != null && (this._metadataExtraDimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the state template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SignalCatalogArn. 
        /// <para>
        /// The ARN of the signal catalog associated with the state template.
        /// </para>
        /// </summary>
        public string SignalCatalogArn
        {
            get { return this._signalCatalogArn; }
            set { this._signalCatalogArn = value; }
        }

        // Check to see if SignalCatalogArn property is set
        internal bool IsSetSignalCatalogArn()
        {
            return this._signalCatalogArn != null;
        }

        /// <summary>
        /// Gets and sets the property StateTemplateProperties. 
        /// <para>
        /// A list of signals from which data is collected. The state template properties contain
        /// the fully qualified names of the signals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public List<string> StateTemplateProperties
        {
            get { return this._stateTemplateProperties; }
            set { this._stateTemplateProperties = value; }
        }

        // Check to see if StateTemplateProperties property is set
        internal bool IsSetStateTemplateProperties()
        {
            return this._stateTemplateProperties != null && (this._stateTemplateProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}