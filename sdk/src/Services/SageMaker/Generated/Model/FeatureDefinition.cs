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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A list of features. You must include <code>FeatureName</code> and <code>FeatureType</code>.
    /// Valid feature <code>FeatureType</code>s are <code>Integral</code>, <code>Fractional</code>
    /// and <code>String</code>.
    /// </summary>
    public partial class FeatureDefinition
    {
        private CollectionConfig _collectionConfig;
        private CollectionType _collectionType;
        private string _featureName;
        private FeatureType _featureType;

        /// <summary>
        /// Gets and sets the property CollectionConfig. 
        /// <para>
        /// Configuration for your collection.
        /// </para>
        /// </summary>
        public CollectionConfig CollectionConfig
        {
            get { return this._collectionConfig; }
            set { this._collectionConfig = value; }
        }

        // Check to see if CollectionConfig property is set
        internal bool IsSetCollectionConfig()
        {
            return this._collectionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CollectionType. 
        /// <para>
        /// A grouping of elements where each element within the collection must have the same
        /// feature type (<code>String</code>, <code>Integral</code>, or <code>Fractional</code>).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>List</code>: An ordered collection of elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Set</code>: An unordered collection of unique elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Vector</code>: A specialized list that represents a fixed-size array of elements.
        /// The vector dimension is determined by you. Must have elements with fractional feature
        /// types. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public CollectionType CollectionType
        {
            get { return this._collectionType; }
            set { this._collectionType = value; }
        }

        // Check to see if CollectionType property is set
        internal bool IsSetCollectionType()
        {
            return this._collectionType != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of a feature. The type must be a string. <code>FeatureName</code> cannot
        /// be any of the following: <code>is_deleted</code>, <code>write_time</code>, <code>api_invocation_time</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The value type of a feature. Valid values are Integral, Fractional, or String.
        /// </para>
        /// </summary>
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

    }
}