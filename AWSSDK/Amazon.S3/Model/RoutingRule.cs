/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for one routing rule that identifies a condition and a redirect that applies when the condition is met.
    /// </summary>
    public class RoutingRule
    {
        RoutingRuleCondition _condition;
        RoutingRuleRedirect _redirect;


        #region Condition

        /// <summary>
        /// A container for describing a condition that must be met for the specified redirect to apply. 
        /// For example if request is for pages in the /docs folder, redirect to the /documents folder or
        /// if request results in HTTP error 4xx, redirect request to another host where you might process the error.
        /// </summary>
        public RoutingRuleCondition Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        /// <summary>
        /// A container for describing a condition that must be met for the specified redirect to apply. 
        /// For example if request is for pages in the /docs folder, redirect to the /documents folder or
        /// if request results in HTTP error 4xx, redirect request to another host where you might process the error.
        /// </summary>
        /// <param name="condition">A container for describing a condition that must be met for the specified redirect to apply. </param>
        /// <returns>the RoutingRuleCondition with the Condition set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RoutingRule WithCondition(RoutingRuleCondition condition)
        {
            this._condition = condition;
            return this;
        }

        /// <summary>
        /// Checks if the Condition property is set.
        /// </summary>
        /// <returns>true if Condition property is set.</returns>
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        #endregion

        #region Redirect

        /// <summary>
        /// Container for redirect information. You can redirect requests to another host, to 
        /// another page, or with another protocol. In the event of an error, you can can specify a different error code to return.
        /// </summary>
        public RoutingRuleRedirect Redirect
        {
            get { return this._redirect; }
            set { this._redirect = value; }
        }

        /// <summary>
        /// You can redirect requests to another host, to 
        /// another page, or with another protocol. In the event of an error, you can can specify a different error code to return.
        /// </summary>
        /// <param name="redirect">The redirect settings for the routing rule.</param>
        /// <returns>the RoutingRuleCondition with the Redirect set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RoutingRule WithRedirect(RoutingRuleRedirect redirect)
        {
            this._redirect = redirect;
            return this;
        }

        /// <summary>
        /// Checks if the Redirect property is set.
        /// </summary>
        /// <returns>true if Redirect property is set.</returns>
        internal bool IsSetRedirect()
        {
            return this._redirect != null;
        }

        #endregion
    }
}
