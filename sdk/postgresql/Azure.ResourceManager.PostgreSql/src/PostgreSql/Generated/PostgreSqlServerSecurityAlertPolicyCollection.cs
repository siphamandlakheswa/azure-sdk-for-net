// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.PostgreSql.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> and their operations.
    /// Each <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> in the collection will belong to the same instance of <see cref="PostgreSqlServerResource" />.
    /// To get a <see cref="PostgreSqlServerSecurityAlertPolicyCollection" /> instance call the GetPostgreSqlServerSecurityAlertPolicies method from an instance of <see cref="PostgreSqlServerResource" />.
    /// </summary>
    public partial class PostgreSqlServerSecurityAlertPolicyCollection : ArmCollection, IEnumerable<PostgreSqlServerSecurityAlertPolicyResource>, IAsyncEnumerable<PostgreSqlServerSecurityAlertPolicyResource>
    {
        private readonly ClientDiagnostics _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics;
        private readonly ServerSecurityAlertPoliciesRestOperations _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlServerSecurityAlertPolicyCollection"/> class for mocking. </summary>
        protected PostgreSqlServerSecurityAlertPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="PostgreSqlServerSecurityAlertPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal PostgreSqlServerSecurityAlertPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.PostgreSql", PostgreSqlServerSecurityAlertPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(PostgreSqlServerSecurityAlertPolicyResource.ResourceType, out string postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesApiVersion);
            _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient = new ServerSecurityAlertPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PostgreSqlServerResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PostgreSqlServerResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a threat detection policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the threat detection policy. </param>
        /// <param name="data"> The server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<PostgreSqlServerSecurityAlertPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, PostgreSqlSecurityAlertPolicyName securityAlertPolicyName, PostgreSqlServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("PostgreSqlServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new PostgreSqlArmOperation<PostgreSqlServerSecurityAlertPolicyResource>(new PostgreSqlServerSecurityAlertPolicyOperationSource(Client), _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics, Pipeline, _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates a threat detection policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="securityAlertPolicyName"> The name of the threat detection policy. </param>
        /// <param name="data"> The server security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<PostgreSqlServerSecurityAlertPolicyResource> CreateOrUpdate(WaitUntil waitUntil, PostgreSqlSecurityAlertPolicyName securityAlertPolicyName, PostgreSqlServerSecurityAlertPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("PostgreSqlServerSecurityAlertPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data, cancellationToken);
                var operation = new PostgreSqlArmOperation<PostgreSqlServerSecurityAlertPolicyResource>(new PostgreSqlServerSecurityAlertPolicyOperationSource(Client), _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics, Pipeline, _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a server's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PostgreSqlServerSecurityAlertPolicyResource>> GetAsync(PostgreSqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("PostgreSqlServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a server's security alert policy.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PostgreSqlServerSecurityAlertPolicyResource> Get(PostgreSqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("PostgreSqlServerSecurityAlertPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the server's threat detection policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlServerSecurityAlertPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlServerSecurityAlertPolicyResource(Client, PostgreSqlServerSecurityAlertPolicyData.DeserializePostgreSqlServerSecurityAlertPolicyData(e)), _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics, Pipeline, "PostgreSqlServerSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the server's threat detection policies.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_ListByServer</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlServerSecurityAlertPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlServerSecurityAlertPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateListByServerRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.CreateListByServerNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new PostgreSqlServerSecurityAlertPolicyResource(Client, PostgreSqlServerSecurityAlertPolicyData.DeserializePostgreSqlServerSecurityAlertPolicyData(e)), _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics, Pipeline, "PostgreSqlServerSecurityAlertPolicyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(PostgreSqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("PostgreSqlServerSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(PostgreSqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("PostgreSqlServerSecurityAlertPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<PostgreSqlServerSecurityAlertPolicyResource>> GetIfExistsAsync(PostgreSqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("PostgreSqlServerSecurityAlertPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlServerSecurityAlertPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/servers/{serverName}/securityAlertPolicies/{securityAlertPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerSecurityAlertPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="securityAlertPolicyName"> The name of the security alert policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<PostgreSqlServerSecurityAlertPolicyResource> GetIfExists(PostgreSqlSecurityAlertPolicyName securityAlertPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesClientDiagnostics.CreateScope("PostgreSqlServerSecurityAlertPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _postgreSqlServerSecurityAlertPolicyServerSecurityAlertPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, securityAlertPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<PostgreSqlServerSecurityAlertPolicyResource>(response.GetRawResponse());
                return Response.FromValue(new PostgreSqlServerSecurityAlertPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<PostgreSqlServerSecurityAlertPolicyResource> IEnumerable<PostgreSqlServerSecurityAlertPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PostgreSqlServerSecurityAlertPolicyResource> IAsyncEnumerable<PostgreSqlServerSecurityAlertPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
