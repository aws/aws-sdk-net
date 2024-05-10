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
    /// Configuration information about the file upload during chat feature for your application.
    /// </summary>
    public partial class AppliedAttachmentsConfiguration
    {
        private AttachmentsControlMode _attachmentsControlMode;

        /// <summary>
        /// Gets and sets the property AttachmentsControlMode. 
        /// <para>
        /// Information about whether file upload during chat functionality is activated for your
        /// application.
        /// </para>
        /// </summary>
        public AttachmentsControlMode AttachmentsControlMode
        {
            get { return this._attachmentsControlMode; }
            set { this._attachmentsControlMode = value; }
        }

        // Check to see if AttachmentsControlMode property is set
        internal bool IsSetAttachmentsControlMode()
        {
            return this._attachmentsControlMode != null;
        }

    }
}