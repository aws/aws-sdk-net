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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Metadata for a system user journey updated event.
    /// </summary>
    public partial class SystemUserJourneyUpdatedMetadata
    {
        private UserJourneyChanges _changes;
        private string _userJourneyName;

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        /// The changes made to the user journey.
        /// </para>
        /// </summary>
        public UserJourneyChanges Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null;
        }

        /// <summary>
        /// Gets and sets the property UserJourneyName. 
        /// <para>
        /// The name of the updated user journey.
        /// </para>
        /// </summary>
        public string UserJourneyName
        {
            get { return this._userJourneyName; }
            set { this._userJourneyName = value; }
        }

        // Check to see if UserJourneyName property is set
        internal bool IsSetUserJourneyName()
        {
            return this._userJourneyName != null;
        }

    }
}