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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies the mainframe action type.
    /// </summary>
    public partial class MainframeActionType
    {
        private Batch _batch;
        private TN3270 _tn3270;

        /// <summary>
        /// Gets and sets the property Batch. 
        /// <para>
        /// The batch of the mainframe action type.
        /// </para>
        /// </summary>
        public Batch Batch
        {
            get { return this._batch; }
            set { this._batch = value; }
        }

        // Check to see if Batch property is set
        internal bool IsSetBatch()
        {
            return this._batch != null;
        }

        /// <summary>
        /// Gets and sets the property Tn3270. 
        /// <para>
        /// The tn3270 port of the mainframe action type.
        /// </para>
        /// </summary>
        public TN3270 Tn3270
        {
            get { return this._tn3270; }
            set { this._tn3270 = value; }
        }

        // Check to see if Tn3270 property is set
        internal bool IsSetTn3270()
        {
            return this._tn3270 != null;
        }

    }
}