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
    /// Container for the parameters to the GetHostnameSuggestion operation.
    /// <para>Gets a generated host name for the specified layer, based on the current host name theme.</para>
    /// </summary>
    /// <seealso cref="Amazon.OpsWorks.AmazonOpsWorks.GetHostnameSuggestion"/>
    public class GetHostnameSuggestionRequest : AmazonWebServiceRequest
    {
        private string layerId;

        /// <summary>
        /// The layer ID.
        ///  
        /// </summary>
        public string LayerId
        {
            get { return this.layerId; }
            set { this.layerId = value; }
        }

        /// <summary>
        /// Sets the LayerId property
        /// </summary>
        /// <param name="layerId">The value to set for the LayerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetHostnameSuggestionRequest WithLayerId(string layerId)
        {
            this.layerId = layerId;
            return this;
        }
            

        // Check to see if LayerId property is set
        internal bool IsSetLayerId()
        {
            return this.layerId != null;
        }
    }
}
    
