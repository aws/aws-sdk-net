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
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for AWS Marketplace.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public static class MarketplaceActionIdentifiers
    {
        public static readonly ActionIdentifier AllMarketplaceActions = new ActionIdentifier("aws-marketplace:*");

        public static readonly ActionIdentifier Subscribe = new ActionIdentifier("aws-marketplace:Subscribe");
        public static readonly ActionIdentifier Unsubscribe = new ActionIdentifier("aws-marketplace:Unsubscribe");
        public static readonly ActionIdentifier ViewSubscriptions = new ActionIdentifier("aws-marketplace:ViewSubscriptions");
    }
}
