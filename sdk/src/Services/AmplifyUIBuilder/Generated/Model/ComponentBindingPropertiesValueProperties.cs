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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
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
namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Represents the data binding configuration for a specific property using data stored
    /// in Amazon Web Services. For Amazon Web Services connected properties, you can bind
    /// a property to data stored in an Amazon S3 bucket, an Amplify DataStore model or an
    /// authenticated user attribute.
    /// </summary>
    public partial class ComponentBindingPropertiesValueProperties
    {
        private string _bucket;
        private string _defaultValue;
        private string _field;
        private string _key;
        private string _model;
        private List<Predicate> _predicates = AWSConfigs.InitializeCollections ? new List<Predicate>() : null;
        private string _slotName;
        private string _userAttribute;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// An Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value to assign to the property.
        /// </para>
        /// </summary>
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field to bind the data to.
        /// </para>
        /// </summary>
        public string Field
        {
            get { return this._field; }
            set { this._field = value; }
        }

        // Check to see if Field property is set
        internal bool IsSetField()
        {
            return this._field != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The storage key for an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// An Amplify DataStore model.
        /// </para>
        /// </summary>
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property Predicates. 
        /// <para>
        /// A list of predicates for binding a component's properties to data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Predicate> Predicates
        {
            get { return this._predicates; }
            set { this._predicates = value; }
        }

        // Check to see if Predicates property is set
        internal bool IsSetPredicates()
        {
            return this._predicates != null && (this._predicates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SlotName. 
        /// <para>
        /// The name of a component slot.
        /// </para>
        /// </summary>
        public string SlotName
        {
            get { return this._slotName; }
            set { this._slotName = value; }
        }

        // Check to see if SlotName property is set
        internal bool IsSetSlotName()
        {
            return this._slotName != null;
        }

        /// <summary>
        /// Gets and sets the property UserAttribute. 
        /// <para>
        /// An authenticated user attribute.
        /// </para>
        /// </summary>
        public string UserAttribute
        {
            get { return this._userAttribute; }
            set { this._userAttribute = value; }
        }

        // Check to see if UserAttribute property is set
        internal bool IsSetUserAttribute()
        {
            return this._userAttribute != null;
        }

    }
}