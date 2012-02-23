/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the GetChange operation.
    /// <para> This action returns the current status of a change batch request. The status is one of the following values:</para> <para>-
    /// <c>PENDING</c> indicates that the changes in this request have not replicated to all Route 53 DNS servers. This is the initial status of all
    /// change batch requests.</para> <para>- <c>INSYNC</c> indicates that the changes have replicated to all Amazon Route 53 DNS servers. </para>
    /// </summary>
    /// <seealso cref="Amazon.Route53.AmazonRoute53.GetChange"/>
    public class GetChangeRequest : AmazonWebServiceRequest
    {
        private string id;

        /// <summary>
        /// The ID of the change batch request. The value that you specify here is the value that <c>ChangeResourceRecordSets</c> returned in the Id
        /// element when you submitted the request.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 32</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        public GetChangeRequest WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;       
        }
    }
}
    
