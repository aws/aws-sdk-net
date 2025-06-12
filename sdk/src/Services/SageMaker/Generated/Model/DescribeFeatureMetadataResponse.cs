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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeFeatureMetadata operation.
    /// </summary>
    public partial class DescribeFeatureMetadataResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _description;
        private string _featureGroupArn;
        private string _featureGroupName;
        private string _featureName;
        private FeatureType _featureType;
        private DateTime? _lastModifiedTime;
        private List<FeatureParameter> _parameters = AWSConfigs.InitializeCollections ? new List<FeatureParameter>() : null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp indicating when the feature was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description you added to describe the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
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
        /// Gets and sets the property FeatureGroupArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the feature group that contains the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string FeatureGroupArn
        {
            get { return this._featureGroupArn; }
            set { this._featureGroupArn = value; }
        }

        // Check to see if FeatureGroupArn property is set
        internal bool IsSetFeatureGroupArn()
        {
            return this._featureGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureGroupName. 
        /// <para>
        /// The name of the feature group that you've specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureGroupName
        {
            get { return this._featureGroupName; }
            set { this._featureGroupName = value; }
        }

        // Check to see if FeatureGroupName property is set
        internal bool IsSetFeatureGroupName()
        {
            return this._featureGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of the feature that you've specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureName
        {
            get { return this._featureName; }
            set { this._featureName = value; }
        }

        // Check to see if FeatureName property is set
        internal bool IsSetFeatureName()
        {
            return this._featureName != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureType. 
        /// <para>
        /// The data type of the feature.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeatureType FeatureType
        {
            get { return this._featureType; }
            set { this._featureType = value; }
        }

        // Check to see if FeatureType property is set
        internal bool IsSetFeatureType()
        {
            return this._featureType != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp indicating when the metadata for the feature group was modified. For example,
        /// if you add a parameter describing the feature, the timestamp changes to reflect the
        /// last time you 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The key-value pairs that you added to describe the feature.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<FeatureParameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}