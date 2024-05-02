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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// This is the response object from the UpdateListener operation.
    /// </summary>
    public partial class UpdateListenerResponse : AmazonWebServiceResponse
    {
        private Listener _listener;

        /// <summary>
        /// Gets and sets the property Listener. 
        /// <para>
        /// Information for the updated listener.
        /// </para>
        /// </summary>
        public Listener Listener
        {
            get { return this._listener; }
            set { this._listener = value; }
        }

        // Check to see if Listener property is set
        internal bool IsSetListener()
        {
            return this._listener != null;
        }

    }
}