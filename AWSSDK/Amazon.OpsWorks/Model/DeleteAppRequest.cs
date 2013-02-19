/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApp operation.
    /// <para>Deletes a specified app.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.DeleteApp"/>
    public class DeleteAppRequest : AmazonWebServiceRequest
    {
        private string appId;

        /// <summary>
        /// The app ID.
        ///  
        /// </summary>
        public string AppId
        {
            get { return this.appId; }
            set { this.appId = value; }
        }

        /// <summary>
        /// Sets the AppId property
        /// </summary>
        /// <param name="appId">The value to set for the AppId property </param>
        /// <returns>this instance</returns>
        public DeleteAppRequest WithAppId(string appId)
        {
            this.appId = appId;
            return this;
        }
            

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this.appId != null;
        }
    }
}
    
