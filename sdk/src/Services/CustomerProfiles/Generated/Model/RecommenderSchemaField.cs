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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Defines a column in a recommender schema, including the target field name and optional
    /// feature and content type settings for training.
    /// </summary>
    public partial class RecommenderSchemaField
    {
        private ContentType _contentType;
        private FeatureType _featureType;
        private string _targetFieldName;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The data type of the column value. Valid values are <c>String</c> and <c>Number</c>.
        /// The default value is <c>String</c>.
        /// </para>
        /// </summary>
        public ContentType ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureType. 
        /// <para>
        /// How the column is treated for model training. Valid values are <c>CATEGORICAL</c>
        /// and <c>TEXTUAL</c>.
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

        /// <summary>
        /// Gets and sets the property TargetFieldName. 
        /// <para>
        /// The name of the target field in the dataset, such as <c>Location.City</c> or <c>Attributes.MealTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string TargetFieldName
        {
            get { return this._targetFieldName; }
            set { this._targetFieldName = value; }
        }

        // Check to see if TargetFieldName property is set
        internal bool IsSetTargetFieldName()
        {
            return this._targetFieldName != null;
        }

    }
}