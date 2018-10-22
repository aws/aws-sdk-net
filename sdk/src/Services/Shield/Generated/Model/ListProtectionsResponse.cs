/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// This is the response object from the ListProtections operation.
    /// </summary>
    public partial class ListProtectionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Protection> _protections = new List<Protection>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify a value for <code>MaxResults</code> and you have more Protections than
        /// the value of MaxResults, AWS Shield Advanced returns a NextToken value in the response
        /// that allows you to list another group of Protections. For the second and subsequent
        /// ListProtections requests, specify the value of NextToken from the previous response
        /// to get information about another batch of Protections.
        /// </para>
        ///  
        /// <para>
        /// AWS WAF might return the list of <a>Protection</a> objects in batches smaller than
        /// the number specified by MaxResults. If there are more <a>Protection</a> objects to
        /// return, AWS WAF will always also return a <code>NextToken</code>.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Protections. 
        /// <para>
        /// The array of enabled <a>Protection</a> objects.
        /// </para>
        /// </summary>
        public List<Protection> Protections
        {
            get { return this._protections; }
            set { this._protections = value; }
        }

        // Check to see if Protections property is set
        internal bool IsSetProtections()
        {
            return this._protections != null && this._protections.Count > 0; 
        }

    }
}