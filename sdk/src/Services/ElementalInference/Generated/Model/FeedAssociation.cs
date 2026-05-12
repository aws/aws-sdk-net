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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Contains information about the resource that is associated with a feed. It is used
    /// in the FeedSummary that is used in the response of a ListFeeds action.
    /// </summary>
    public partial class FeedAssociation
    {
        private string _associatedResourceName;

        /// <summary>
        /// Gets and sets the property AssociatedResourceName. 
        /// <para>
        /// The name of the associated resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AssociatedResourceName
        {
            get { return this._associatedResourceName; }
            set { this._associatedResourceName = value; }
        }

        // Check to see if AssociatedResourceName property is set
        internal bool IsSetAssociatedResourceName()
        {
            return this._associatedResourceName != null;
        }

    }
}