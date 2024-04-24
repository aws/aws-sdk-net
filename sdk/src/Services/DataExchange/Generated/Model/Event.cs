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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// What occurs to start an action.
    /// </summary>
    public partial class Event
    {
        private RevisionPublished _revisionPublished;

        /// <summary>
        /// Gets and sets the property RevisionPublished. 
        /// <para>
        /// What occurs to start the revision publish action.
        /// </para>
        /// </summary>
        public RevisionPublished RevisionPublished
        {
            get { return this._revisionPublished; }
            set { this._revisionPublished = value; }
        }

        // Check to see if RevisionPublished property is set
        internal bool IsSetRevisionPublished()
        {
            return this._revisionPublished != null;
        }

    }
}