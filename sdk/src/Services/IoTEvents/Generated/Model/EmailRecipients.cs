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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Contains the information of one or more recipients who receive the emails.
    /// 
    ///  <important> 
    /// <para>
    /// You must <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/addusers.html">add
    /// the users that receive emails to your AWS SSO store</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class EmailRecipients
    {
        private List<RecipientDetail> _to = AWSConfigs.InitializeCollections ? new List<RecipientDetail>() : null;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// Specifies one or more recipients who receive the email.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<RecipientDetail> To
        {
            get { return this._to; }
            set { this._to = value; }
        }

        // Check to see if To property is set
        internal bool IsSetTo()
        {
            return this._to != null && (this._to.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}