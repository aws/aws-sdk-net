/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListGroupsForUser operation.
    /// <para>Lists the groups the specified User belongs to.</para> <para>You
    /// can paginate the results using the <c>MaxItems</c> and <c>Marker</c>
    /// parameters.</para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.ListGroupsForUser"/>
    public class ListGroupsForUserRequest : AmazonWebServiceRequest
    {
        private string userName;
        private string marker;
        private int? maxItems;

        /// <summary>
        /// The name of the User to list groups for.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        public ListGroupsForUserRequest WithUserName(string userName)
        {
            this.userName = userName;
            return this;
        }
            
        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;       
        }

        /// <summary>
        /// Use this only when paginating results, and only in a subsequent
        /// request after you've received a response where the results are
        /// truncated. Set it to the value of the <c>Marker</c> element in the
        /// response you just received.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 320</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\u00FF]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public ListGroupsForUserRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            
        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;         
        }

        /// <summary>
        /// Use this only when paginating results to indicate the maximum number
        /// of groups you want in the response. If there are additional groups
        /// beyond the maximum you specify, the <c>IsTruncated</c> response
        /// element is <c>true</c>.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 1000</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this.maxItems ?? default(int); }
            set { this.maxItems = value; }
        }

        /// <summary>
        /// Sets the MaxItems property
        /// </summary>
        /// <param name="maxItems">The value to set for the MaxItems property </param>
        /// <returns>this instance</returns>
        public ListGroupsForUserRequest WithMaxItems(int maxItems)
        {
            this.maxItems = maxItems;
            return this;
        }
            
        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this.maxItems.HasValue;      
        }
    }
}
    
