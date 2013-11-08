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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents a list of all verified identities for the AWS Account.</para>
    /// </summary>
    public partial class ListIdentitiesResult : AmazonWebServiceResponse
    {
        
        private List<string> identities = new List<string>();
        private string nextToken;

        /// <summary>
        /// A list of identities.
        ///  
        /// </summary>
        public List<string> Identities
        {
            get { return this.identities; }
            set { this.identities = value; }
        }

        // Check to see if Identities property is set
        internal bool IsSetIdentities()
        {
            return this.identities.Count > 0;
        }

        /// <summary>
        /// The token used for pagination.
        ///  
        /// </summary>
        public string NextToken
        {
            get { return this.nextToken; }
            set { this.nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
