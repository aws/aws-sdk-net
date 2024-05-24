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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// An item referenced in a <c>TimelineEvent</c> that is involved in or somehow associated
    /// with an incident. You can specify an Amazon Resource Name (ARN) for an Amazon Web
    /// Services resource or a <c>RelatedItem</c> ID.
    /// </summary>
    public partial class EventReference
    {
        private string _relatedItemId;
        private string _resource;

        /// <summary>
        /// Gets and sets the property RelatedItemId. 
        /// <para>
        /// The ID of a <c>RelatedItem</c> referenced in a <c>TimelineEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string RelatedItemId
        {
            get { return this._relatedItemId; }
            set { this._relatedItemId = value; }
        }

        // Check to see if RelatedItemId property is set
        internal bool IsSetRelatedItemId()
        {
            return this._relatedItemId != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Web Services resource referenced in a
        /// <c>TimelineEvent</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

    }
}