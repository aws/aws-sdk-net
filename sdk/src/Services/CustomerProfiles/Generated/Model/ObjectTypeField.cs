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
    /// Represents a field in a ProfileObjectType.
    /// </summary>
    public partial class ObjectTypeField
    {
        private FieldContentType _contentType;
        private string _source;
        private string _target;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the field. Used for determining equality when searching.
        /// </para>
        /// </summary>
        public FieldContentType ContentType
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
        /// Gets and sets the property Source. 
        /// <para>
        /// A field of a ProfileObject. For example: _source.FirstName, where “_source” is a ProfileObjectType
        /// of a Zendesk user and “FirstName” is a field in that ObjectType.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The location of the data in the standard ProfileObject model. For example: _profile.Address.PostalCode.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

    }
}