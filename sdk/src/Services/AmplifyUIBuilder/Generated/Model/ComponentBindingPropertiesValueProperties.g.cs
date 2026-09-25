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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// An Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property DefaultValue. 
        /// <para>
        /// The default value to assign to the property.
        /// </para>
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Checks to see if the DefaultValue property is set.
        /// </summary>
        internal bool IsSetDefaultValue() => this.DefaultValue != null;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field to bind the data to.
        /// </para>
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Checks to see if the Field property is set.
        /// </summary>
        internal bool IsSetField() => this.Field != null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The storage key for an Amazon S3 bucket.
        /// </para>
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Model. 
        /// <para>
        /// An Amplify DataStore model.
        /// </para>
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Checks to see if the Model property is set.
        /// </summary>
        internal bool IsSetModel() => this.Model != null;

        /// <summary>
        /// Gets and sets the property Predicates. 
        /// <para>
        /// A list of predicates for binding a component's properties to data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Predicate> Predicates { get; set; } = AWSConfigs.InitializeCollections ? new List<Predicate>() : null;

        /// <summary>
        /// Checks to see if the Predicates property is set.
        /// </summary>
        internal bool IsSetPredicates() => this.Predicates != null && (this.Predicates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SlotName. 
        /// <para>
        /// The name of a component slot.
        /// </para>
        /// </summary>
        public string SlotName { get; set; }

        /// <summary>
        /// Checks to see if the SlotName property is set.
        /// </summary>
        internal bool IsSetSlotName() => this.SlotName != null;

        /// <summary>
        /// Gets and sets the property UserAttribute. 
        /// <para>
        /// An authenticated user attribute.
        /// </para>
        /// </summary>
        public string UserAttribute { get; set; }

        /// <summary>
        /// Checks to see if the UserAttribute property is set.
        /// </summary>
        internal bool IsSetUserAttribute() => this.UserAttribute != null;
    }
}
