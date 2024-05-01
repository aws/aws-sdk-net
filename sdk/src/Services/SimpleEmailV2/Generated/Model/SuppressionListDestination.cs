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
    /// An object that contains details about the action of suppression list.
    /// </summary>
    public partial class SuppressionListDestination
    {
        private SuppressionListImportAction _suppressionListImportAction;

        /// <summary>
        /// Gets and sets the property SuppressionListImportAction. 
        /// <para>
        /// The type of action to perform on the address. The following are possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PUT: add the addresses to the suppression list. If the record already exists, it will
        /// override it with the new value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE: remove the addresses from the suppression list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public SuppressionListImportAction SuppressionListImportAction
        {
            get { return this._suppressionListImportAction; }
            set { this._suppressionListImportAction = value; }
        }

        // Check to see if SuppressionListImportAction property is set
        internal bool IsSetSuppressionListImportAction()
        {
            return this._suppressionListImportAction != null;
        }

    }
}