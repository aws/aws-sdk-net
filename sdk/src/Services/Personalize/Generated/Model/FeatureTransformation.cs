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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Provides feature transformation information. Feature transformation is the process
    /// of modifying raw input data into a form more suitable for model training.
    /// </summary>
    public partial class FeatureTransformation
    {
        private DateTime? _creationDateTime;
        private Dictionary<string, string> _defaultParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _featureTransformationArn;
        private DateTime? _lastUpdatedDateTime;
        private string _name;
        private string _status;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation date and time (in Unix time) of the feature transformation.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultParameters. 
        /// <para>
        /// Provides the default parameters for feature transformation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> DefaultParameters
        {
            get { return this._defaultParameters; }
            set { this._defaultParameters = value; }
        }

        // Check to see if DefaultParameters property is set
        internal bool IsSetDefaultParameters()
        {
            return this._defaultParameters != null && (this._defaultParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FeatureTransformationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the FeatureTransformation object.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FeatureTransformationArn
        {
            get { return this._featureTransformationArn; }
            set { this._featureTransformationArn = value; }
        }

        // Check to see if FeatureTransformationArn property is set
        internal bool IsSetFeatureTransformationArn()
        {
            return this._featureTransformationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The last update date and time (in Unix time) of the feature transformation.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the feature transformation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the feature transformation.
        /// </para>
        ///  
        /// <para>
        /// A feature transformation can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}