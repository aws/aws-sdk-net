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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// The settings of the CDC stream of the table. For more information about CDC streams,
    /// see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/cdc.html">Working
    /// with change data capture (CDC) streams in Amazon Keyspaces</a> in the <i>Amazon Keyspaces
    /// Developer Guide</i>.
    /// </summary>
    public partial class CdcSpecificationSummary
    {
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the CDC stream. Specifies if the table has a CDC stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CdcStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ViewType. 
        /// <para>
        /// The view type specifies the changes Amazon Keyspaces records for each changed row
        /// in the stream. This setting can't be changed, after the stream has been created. 
        /// </para>
        ///  
        /// <para>
        /// The options are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW_AND_OLD_IMAGES</c> - both versions of the row, before and after the change.
        /// This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_IMAGE</c> - the version of the row after the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OLD_IMAGE</c> - the version of the row before the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - the partition and clustering keys of the row that was changed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ViewType ViewType { get; set; }

        /// <summary>
        /// Checks to see if the ViewType property is set.
        /// </summary>
        internal bool IsSetViewType() => this.ViewType != null;
    }
}
