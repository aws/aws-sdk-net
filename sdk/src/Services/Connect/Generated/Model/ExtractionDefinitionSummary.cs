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
    /// Summary information about an extraction definition.
    /// </summary>
    public partial class ExtractionDefinitionSummary
    {
        private DateTime? _createdTime;
        private string _extractionDefinitionArn;
        private string _extractionDefinitionId;
        private string _lastUpdatedBy;
        private DateTime? _lastUpdatedTime;
        private string _name;

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

    }
}