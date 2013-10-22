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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Container for the parameters to the ListWorkflowTypes operation.
    /// <para> Returns information about workflow types in the specified domain. The results may be split into multiple pages that can be retrieved
    /// by making the call repeatedly. </para> <para> <b>Access Control</b> </para> <para>You can use IAM policies to control this action's access
    /// to Amazon SWF resources as follows:</para>
    /// <ul>
    /// <li>Use a <c>Resource</c> element with the domain name to limit the action to only specified domains.</li>
    /// <li>Use an <c>Action</c> element to allow or deny permission to call this action.</li>
    /// <li>You cannot use an IAM policy to constrain this action's parameters.</li>
    /// 
    /// </ul>
    /// <para>If the caller does not have sufficient permissions to invoke the action, or the parameter values fall outside the specified
    /// constraints, the action fails by throwing <c>OperationNotPermitted</c> . For details and example IAM policies, see <a
    /// href="http://docs.aws.amazon.com/amazonswf/latest/developerguide/swf-dev-iam.html" >Using IAM to Manage Access to Amazon SWF Workflows</a>
    /// .</para>
    /// </summary>
    public partial class ListWorkflowTypesRequest : AmazonWebServiceRequest
    {
        private string domain;
        private string name;
        private RegistrationStatus registrationStatus;
        private string nextPageToken;
        private int? maximumPageSize;
        private bool? reverseOrder;

        /// <summary>
        /// The name of the domain in which the workflow types have been registered.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this.domain != null;
        }

        /// <summary>
        /// If specified, lists the workflow type with this name.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 256</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// Specifies the registration status of the workflow types to list.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>REGISTERED, DEPRECATED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public RegistrationStatus RegistrationStatus
        {
            get { return this.registrationStatus; }
            set { this.registrationStatus = value; }
        }

        // Check to see if RegistrationStatus property is set
        internal bool IsSetRegistrationStatus()
        {
            return this.registrationStatus != null;
        }

        /// <summary>
        /// If on a previous call to this method a <c>NextPageToken</c> was returned, the results are being paginated. To get the next page of results,
        /// repeat the call with the returned token and all other arguments unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }

        /// <summary>
        /// The maximum number of results returned in each page. The default is 100, but the caller can override this value to a page size
        /// <i>smaller</i> than the default. You cannot specify a page size greater than 100. Note that the number of types may be less than the
        /// maxiumum page size, in which case, the returned page will have fewer results than the maximumPageSize specified.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>0 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaximumPageSize
        {
            get { return this.maximumPageSize ?? default(int); }
            set { this.maximumPageSize = value; }
        }

        // Check to see if MaximumPageSize property is set
        internal bool IsSetMaximumPageSize()
        {
            return this.maximumPageSize.HasValue;
        }

        /// <summary>
        /// When set to <c>true</c>, returns the results in reverse order. By default the results are returned in ascending alphabetical order of the
        /// <c>name</c> of the workflow types.
        ///  
        /// </summary>
        public bool ReverseOrder
        {
            get { return this.reverseOrder ?? default(bool); }
            set { this.reverseOrder = value; }
        }

        // Check to see if ReverseOrder property is set
        internal bool IsSetReverseOrder()
        {
            return this.reverseOrder.HasValue;
        }

    }
}
    
