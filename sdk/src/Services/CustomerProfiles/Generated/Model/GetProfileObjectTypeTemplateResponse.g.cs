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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetProfileObjectTypeTemplate operation.
    /// </summary>
    public partial class GetProfileObjectTypeTemplateResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AllowProfileCreation. 
        /// <para>
        /// Indicates whether a profile should be created when data is received if one doesn’t
        /// exist for an object of this type. The default is <c>FALSE</c>. If the AllowProfileCreation
        /// flag is set to <c>FALSE</c>, then the service tries to fetch a standard profile and
        /// associate this object with the profile. If it is set to <c>TRUE</c>, and if no match
        /// is found, then the service creates a new standard profile.
        /// </para>
        /// </summary>
        public bool? AllowProfileCreation { get; set; }

        /// <summary>
        /// Checks to see if the AllowProfileCreation property is set.
        /// </summary>
        internal bool IsSetAllowProfileCreation() => this.AllowProfileCreation.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultMaxProfileObjectCount. 
        /// <para>
        /// The default maximum number of objects of this object type that can be stored per profile.
        /// This default applies when you don't set <c>MaxProfileObjectCount</c> on an object
        /// type created from this template. If this value isn't present, no default limit applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? DefaultMaxProfileObjectCount { get; set; }

        /// <summary>
        /// Checks to see if the DefaultMaxProfileObjectCount property is set.
        /// </summary>
        internal bool IsSetDefaultMaxProfileObjectCount() => this.DefaultMaxProfileObjectCount.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultMaxProfileObjectCountEffectiveAfter. 
        /// <para>
        /// The timestamp after which <c>DefaultMaxProfileObjectCount</c> takes effect. The default
        /// limit applies only to domains created after this time.
        /// </para>
        /// </summary>
        public DateTime? DefaultMaxProfileObjectCountEffectiveAfter { get; set; }

        /// <summary>
        /// Checks to see if the DefaultMaxProfileObjectCountEffectiveAfter property is set.
        /// </summary>
        internal bool IsSetDefaultMaxProfileObjectCountEffectiveAfter() => this.DefaultMaxProfileObjectCountEffectiveAfter.HasValue;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A map of the name and ObjectType field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, ObjectTypeField> Fields { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ObjectTypeField>() : null;

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null && (this.Fields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// A list of unique keys that can be used to map data to the profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, List<ObjectTypeKey>> Keys { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<ObjectTypeKey>>() : null;

        /// <summary>
        /// Checks to see if the Keys property is set.
        /// </summary>
        internal bool IsSetKeys() => this.Keys != null && (this.Keys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceLastUpdatedTimestampFormat. 
        /// <para>
        /// The format of your <c>sourceLastUpdatedTimestamp</c> that was previously set up.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SourceLastUpdatedTimestampFormat { get; set; }

        /// <summary>
        /// Checks to see if the SourceLastUpdatedTimestampFormat property is set.
        /// </summary>
        internal bool IsSetSourceLastUpdatedTimestampFormat() => this.SourceLastUpdatedTimestampFormat != null;

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the source of the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceName property is set.
        /// </summary>
        internal bool IsSetSourceName() => this.SourceName != null;

        /// <summary>
        /// Gets and sets the property SourceObject. 
        /// <para>
        /// The source of the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string SourceObject { get; set; }

        /// <summary>
        /// Checks to see if the SourceObject property is set.
        /// </summary>
        internal bool IsSetSourceObject() => this.SourceObject != null;

        /// <summary>
        /// Gets and sets the property StoreOnly. 
        /// <para>
        /// Indicates whether the template is store-only. Objects of an object type created from
        /// a store-only template are ingested and stored, but the object type can't be used by
        /// calculated attributes or event triggers.
        /// </para>
        /// </summary>
        public bool? StoreOnly { get; set; }

        /// <summary>
        /// Checks to see if the StoreOnly property is set.
        /// </summary>
        internal bool IsSetStoreOnly() => this.StoreOnly.HasValue;

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// A unique identifier for the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;
    }
}
