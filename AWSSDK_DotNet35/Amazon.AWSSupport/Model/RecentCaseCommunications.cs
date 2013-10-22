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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// <para>List of <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_Communication.html" >Commmunication</a> objects.</para>
    /// </summary>
    public class RecentCaseCommunications
    {
        
        private List<Communication> communications = new List<Communication>();
        private string nextToken;

        /// <summary>
        /// List of <a href="http://docs.aws.amazon.com/awssupport/latest/APIReference/API_Communication.html" title="Communication">Commmunication</a>
        /// objects.
        ///  
        /// </summary>
        public List<Communication> Communications
        {
            get { return this.communications; }
            set { this.communications = value; }
        }

        // Check to see if Communications property is set
        internal bool IsSetCommunications()
        {
            return this.communications.Count > 0;
        }

        /// <summary>
        /// Defines a resumption point for pagination.
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
