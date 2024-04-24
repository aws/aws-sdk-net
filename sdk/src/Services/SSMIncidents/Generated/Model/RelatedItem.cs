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
    /// Resources that responders use to triage and mitigate the incident.
    /// </summary>
    public partial class RelatedItem
    {
        private string _generatedId;
        private ItemIdentifier _identifier;
        private string _title;

        /// <summary>
        /// Gets and sets the property GeneratedId. 
        /// <para>
        /// A unique ID for a <c>RelatedItem</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Don't specify this parameter when you add a <c>RelatedItem</c> by using the <a>UpdateRelatedItems</a>
        /// API action.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string GeneratedId
        {
            get { return this._generatedId; }
            set { this._generatedId = value; }
        }

        // Check to see if GeneratedId property is set
        internal bool IsSetGeneratedId()
        {
            return this._generatedId != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// Details about the related item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ItemIdentifier Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the related item.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}