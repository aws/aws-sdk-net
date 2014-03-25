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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The result of a <c>DeleteSuggester</c> request. Contains the status of the deleted suggester.</para>
    /// </summary>
    public partial class DeleteSuggesterResult : AmazonWebServiceResponse
    {
        
        private SuggesterStatus suggester;


        /// <summary>
        /// The status of the suggester being deleted.
        ///  
        /// </summary>
        public SuggesterStatus Suggester
        {
            get { return this.suggester; }
            set { this.suggester = value; }
        }

        // Check to see if Suggester property is set
        internal bool IsSetSuggester()
        {
            return this.suggester != null;
        }
    }
}
