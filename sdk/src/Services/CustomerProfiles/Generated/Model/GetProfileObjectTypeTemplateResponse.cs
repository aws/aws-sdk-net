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
    /// This is the response object from the GetProfileObjectTypeTemplate operation.
    /// </summary>
    public partial class GetProfileObjectTypeTemplateResponse : AmazonWebServiceResponse
    {
        private bool? _allowProfileCreation;
        private Dictionary<string, ObjectTypeField> _fields = AWSConfigs.InitializeCollections ? new Dictionary<string, ObjectTypeField>() : null;
        private Dictionary<string, List<ObjectTypeKey>> _keys = AWSConfigs.InitializeCollections ? new Dictionary<string, List<ObjectTypeKey>>() : null;
        private string _sourceLastUpdatedTimestampFormat;
        private string _sourceName;
        private string _sourceObject;
        private string _templateId;

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
        public bool? AllowProfileCreation
        {
            get { return this._allowProfileCreation; }
            set { this._allowProfileCreation = value; }
        }

        // Check to see if AllowProfileCreation property is set
        internal bool IsSetAllowProfileCreation()
        {
            return this._allowProfileCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A map of the name and ObjectType field.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, ObjectTypeField> Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null && (this._fields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Keys. 
        /// <para>
        /// A list of unique keys that can be used to map data to the profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, List<ObjectTypeKey>> Keys
        {
            get { return this._keys; }
            set { this._keys = value; }
        }

        // Check to see if Keys property is set
        internal bool IsSetKeys()
        {
            return this._keys != null && (this._keys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceLastUpdatedTimestampFormat. 
        /// <para>
        /// The format of your <c>sourceLastUpdatedTimestamp</c> that was previously set up.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SourceLastUpdatedTimestampFormat
        {
            get { return this._sourceLastUpdatedTimestampFormat; }
            set { this._sourceLastUpdatedTimestampFormat = value; }
        }

        // Check to see if SourceLastUpdatedTimestampFormat property is set
        internal bool IsSetSourceLastUpdatedTimestampFormat()
        {
            return this._sourceLastUpdatedTimestampFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name of the source of the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceObject. 
        /// <para>
        /// The source of the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string SourceObject
        {
            get { return this._sourceObject; }
            set { this._sourceObject = value; }
        }

        // Check to see if SourceObject property is set
        internal bool IsSetSourceObject()
        {
            return this._sourceObject != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// A unique identifier for the object template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

    }
}