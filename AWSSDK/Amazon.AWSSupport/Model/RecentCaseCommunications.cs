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
    /// <para>List of Commmunication objects.</para>
    /// </summary>
    public class RecentCaseCommunications
    {
        
        private List<Communication> communications = new List<Communication>();
        private string nextToken;

        /// <summary>
        /// List of <a href="API_Communication.html" title="Communication">Commmunication</a> objects.
        ///  
        /// </summary>
        public List<Communication> Communications
        {
            get { return this.communications; }
            set { this.communications = value; }
        }
        /// <summary>
        /// Adds elements to the Communications collection
        /// </summary>
        /// <param name="communications">The values to add to the Communications collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RecentCaseCommunications WithCommunications(params Communication[] communications)
        {
            foreach (Communication element in communications)
            {
                this.communications.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Communications collection
        /// </summary>
        /// <param name="communications">The values to add to the Communications collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RecentCaseCommunications WithCommunications(IEnumerable<Communication> communications)
        {
            foreach (Communication element in communications)
            {
                this.communications.Add(element);
            }

            return this;
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

        /// <summary>
        /// Sets the NextToken property
        /// </summary>
        /// <param name="nextToken">The value to set for the NextToken property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RecentCaseCommunications WithNextToken(string nextToken)
        {
            this.nextToken = nextToken;
            return this;
        }
            

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this.nextToken != null;
        }
    }
}
