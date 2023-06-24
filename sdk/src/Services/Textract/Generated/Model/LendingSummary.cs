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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Contains information regarding DocumentGroups and UndetectedDocumentTypes.
    /// </summary>
    public partial class LendingSummary
    {
        private List<DocumentGroup> _documentGroups = new List<DocumentGroup>();
        private List<string> _undetectedDocumentTypes = new List<string>();

        /// <summary>
        /// Gets and sets the property DocumentGroups. 
        /// <para>
        /// Contains an array of all DocumentGroup objects.
        /// </para>
        /// </summary>
        public List<DocumentGroup> DocumentGroups
        {
            get { return this._documentGroups; }
            set { this._documentGroups = value; }
        }

        // Check to see if DocumentGroups property is set
        internal bool IsSetDocumentGroups()
        {
            return this._documentGroups != null && this._documentGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UndetectedDocumentTypes. 
        /// <para>
        /// UndetectedDocumentTypes.
        /// </para>
        /// </summary>
        public List<string> UndetectedDocumentTypes
        {
            get { return this._undetectedDocumentTypes; }
            set { this._undetectedDocumentTypes = value; }
        }

        // Check to see if UndetectedDocumentTypes property is set
        internal bool IsSetUndetectedDocumentTypes()
        {
            return this._undetectedDocumentTypes != null && this._undetectedDocumentTypes.Count > 0; 
        }

    }
}