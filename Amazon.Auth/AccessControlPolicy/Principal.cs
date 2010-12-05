﻿/*
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
using System.Text;

namespace Amazon.Auth.AccessControlPolicy
{
    /// <summary>
    /// A principal is an AWS account which is being allowed or denied access to a
    /// resource through an access control policy. The principal is a property of the
    /// Statement object, not directly the <see cref="Amazon.Auth.AccessControlPolicy.Policy"/> object.
    /// <para>
    /// The principal is A in the statement
    /// "A has permission to do B to C where D applies."
    /// </para>
    /// <para>
    /// In an access control policy statement, you can set the principal to all
    /// authenticated AWS users through the <see cref="Amazon.Auth.AccessControlPolicy.Principal.AllUsers"/> member. This
    /// is useful when you don't want to restrict access based on the identity of the
    /// requester, but instead on other identifying characteristics such as the
    /// requester's IP address.
    /// </para>
    /// </summary>
    public class Principal
    {
        /// <summary>
        /// Principal instance that includes all users, including anonymous users.
        /// <para>
        /// This is useful when you don't want to restrict access based on the
        /// identity of the requester, but instead on other identifying
        /// characteristics such as the requester's IP address.
        /// </para>
        /// </summary>
        public static readonly Principal AllUsers = new Principal("*");

        /// <summary>
        /// The default Principal provider for AWS accounts.
        /// </summary>
        public const string AWS_PROVIDER = "AWS";

        /// <summary>
        /// Principal provider for Canonical User IDs.
        /// </summary>
        public const string CANONICAL_USER_PROVIDER = "CanonicalUser";

        private string id;
        private string provider;

        /// <summary>
        /// Constructs a new principal with the specified AWS account ID.
        /// </summary>
        /// <param name="accountId">An AWS account ID.</param>
        public Principal(string accountId) 
        {
            this.provider = AWS_PROVIDER;
            if (accountId == null) 
            {
                throw new ArgumentNullException("accountId");
            }
            this.id = accountId.Replace("-", "");
        }

        /// <summary>
        /// Gets and sets the provider for this principal, which indicates in what group of
        /// users this principal resides.
        /// </summary>
        public string Provider
        {
            get
            {
                return provider;
            }
            set
            {
                provider = value;
            }
        }

        /// <summary>
        /// Gets the unique ID for this principal.
        /// </summary>
        public string Id
        {
            get
            {
                return id;
            }
        }
    }
}

