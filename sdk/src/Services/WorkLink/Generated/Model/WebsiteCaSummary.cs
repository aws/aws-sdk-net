/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkLink.Model
{
    /// <summary>
    /// The summary of the certificate authority (CA).
    /// </summary>
    public partial class WebsiteCaSummary
    {
        private DateTime? _createdTime;
        private string _displayName;
        private string _websiteCaId;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time when the CA was added.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name to display.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property WebsiteCaId. 
        /// <para>
        /// A unique identifier for the CA.
        /// </para>
        /// </summary>
        public string WebsiteCaId
        {
            get { return this._websiteCaId; }
            set { this._websiteCaId = value; }
        }

        // Check to see if WebsiteCaId property is set
        internal bool IsSetWebsiteCaId()
        {
            return this._websiteCaId != null;
        }

    }
}