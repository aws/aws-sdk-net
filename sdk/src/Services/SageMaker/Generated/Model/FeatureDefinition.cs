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
    /// A list of features. You must include <c>FeatureName</c> and <c>FeatureType</c>. Valid
    /// feature <c>FeatureType</c>s are <c>Integral</c>, <c>Fractional</c> and <c>String</c>.
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
        /// feature type (<c>String</c>, <c>Integral</c>, or <c>Fractional</c>).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>List</c>: An ordered collection of elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Set</c>: An unordered collection of unique elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Vector</c>: A specialized list that represents a fixed-size array of elements.
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
        /// The name of a feature. The type must be a string. <c>FeatureName</c> cannot be any
        /// of the following: <c>is_deleted</c>, <c>write_time</c>, <c>api_invocation_time</c>.
        /// </para>
        ///  
        /// <para>
        /// The name:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must start with an alphanumeric character.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can only include alphanumeric characters, underscores, and hyphens. Spaces are not
        /// allowed.
        /// </para>
        ///  </li> </ul>
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
        /// The value type of a feature. Valid values are Integral, Fractional, or String.
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

    }
}