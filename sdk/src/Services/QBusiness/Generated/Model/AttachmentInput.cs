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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is either a file directly uploaded into a web experience chat or a reference
    /// to an existing attachment that is part of a web experience chat.
    /// </summary>
    public partial class AttachmentInput
    {
        private CopyFromSource _copyFrom;
        private MemoryStream _data;
        private string _name;

        /// <summary>
        /// Gets and sets the property CopyFrom. 
        /// <para>
        /// A reference to an existing attachment.
        /// </para>
        /// </summary>
        public CopyFromSource CopyFrom
        {
            get { return this._copyFrom; }
            set { this._copyFrom = value; }
        }

        // Check to see if CopyFrom property is set
        internal bool IsSetCopyFrom()
        {
            return this._copyFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The contents of the attachment.
        /// </para>
        /// </summary>
        public MemoryStream Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The filename of the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}