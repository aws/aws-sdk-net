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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about an extraction definition.
    /// </summary>
    public partial class ExtractionDefinition
    {
        private DateTime? _createdTime;
        private ExtractionDefinitionDisplay _display;
        private ExtractionConfiguration _extractionConfiguration;
        private string _extractionDefinitionArn;
        private string _extractionDefinitionId;
        private string _lastUpdatedBy;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the extraction definition was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Display. 
        /// <para>
        /// The display settings for the extraction definition.
        /// </para>
        /// </summary>
        public ExtractionDefinitionDisplay Display
        {
            get { return this._display; }
            set { this._display = value; }
        }

        // Check to see if Display property is set
        internal bool IsSetDisplay()
        {
            return this._display != null;
        }

        /// <summary>
        /// Gets and sets the property ExtractionConfiguration. 
        /// <para>
        /// The configuration that defines how data is extracted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExtractionConfiguration ExtractionConfiguration
        {
            get { return this._extractionConfiguration; }
            set { this._extractionConfiguration = value; }
        }

        // Check to see if ExtractionConfiguration property is set
        internal bool IsSetExtractionConfiguration()
        {
            return this._extractionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExtractionDefinitionArn
        {
            get { return this._extractionDefinitionArn; }
            set { this._extractionDefinitionArn = value; }
        }

        // Check to see if ExtractionDefinitionArn property is set
        internal bool IsSetExtractionDefinitionArn()
        {
            return this._extractionDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExtractionDefinitionId. 
        /// <para>
        /// The identifier of the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ExtractionDefinitionId
        {
            get { return this._extractionDefinitionId; }
            set { this._extractionDefinitionId = value; }
        }

        // Check to see if ExtractionDefinitionId property is set
        internal bool IsSetExtractionDefinitionId()
        {
            return this._extractionDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user who last updated the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the extraction definition was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the extraction definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}