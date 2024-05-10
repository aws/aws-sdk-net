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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains details about the resource destination the import job is going
    /// to target.
    /// </summary>
    public partial class ImportDestination
    {
        private ContactListDestination _contactListDestination;
        private SuppressionListDestination _suppressionListDestination;

        /// <summary>
        /// Gets and sets the property ContactListDestination. 
        /// <para>
        /// An object that contains the action of the import job towards a contact list.
        /// </para>
        /// </summary>
        public ContactListDestination ContactListDestination
        {
            get { return this._contactListDestination; }
            set { this._contactListDestination = value; }
        }

        // Check to see if ContactListDestination property is set
        internal bool IsSetContactListDestination()
        {
            return this._contactListDestination != null;
        }

        /// <summary>
        /// Gets and sets the property SuppressionListDestination. 
        /// <para>
        /// An object that contains the action of the import job towards suppression list.
        /// </para>
        /// </summary>
        public SuppressionListDestination SuppressionListDestination
        {
            get { return this._suppressionListDestination; }
            set { this._suppressionListDestination = value; }
        }

        // Check to see if SuppressionListDestination property is set
        internal bool IsSetSuppressionListDestination()
        {
            return this._suppressionListDestination != null;
        }

    }
}