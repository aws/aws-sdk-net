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
    /// The available AWS access control policy actions for AWS Billing.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public static class BillingActionIdentifiers
    {
        public static readonly ActionIdentifier AllBillingActions = new ActionIdentifier("aws-portal:*");

        public static readonly ActionIdentifier ModifyAccount = new ActionIdentifier("aws-portal:ModifyAccount");
        public static readonly ActionIdentifier ModifyBilling = new ActionIdentifier("aws-portal:ModifyBilling");
        public static readonly ActionIdentifier ModifyPaymentMethods = new ActionIdentifier("aws-portal:ModifyPaymentMethods");
        public static readonly ActionIdentifier ViewAccount = new ActionIdentifier("aws-portal:ViewAccount");
        public static readonly ActionIdentifier ViewBilling = new ActionIdentifier("aws-portal:ViewBilling");
        public static readonly ActionIdentifier ViewPaymentMethods = new ActionIdentifier("aws-portal:ViewPaymentMethods");
        public static readonly ActionIdentifier ViewUsage = new ActionIdentifier("aws-portal:ViewUsage");
    }
}
